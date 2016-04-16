
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;


namespace Teaching
{


    public partial class UpdaterForm : Form
    {

        private class FileDownloadData
        {
            public string SourceFilename { get; set; }
            public string DestinationFilename{ get; set; }
            public int Size { get; set; }
            public string Hash { get; set; }
        }

        private bool _boolConsiderBetas, _boolUpdaterNeedUpdated;
        private int _intTotalToDownload, _intDownloadedAlready;
        private XmlDocument _xDocVersionData = new XmlDocument();
        private XmlElement _xSelectedVersion;
        private string _strUpdateFolder;
        private string _strInstallFolder;
        private string _currentVersion;
        private ApplicationSettings _appSettings;

        DateTime _dtDefault = new DateTime(2010, 1, 1);


        private const string BASE_URL = "http://trulymail.com/TeachingApp/";
        private List<FileDownloadData> _lstFilesToDownload = new List<FileDownloadData>() ;
        private WebClient _wcDownloadFile = new WebClient();

        public class VersionUpdateData
        {
            public enum UpdateTypeEnum { Unknown, NoUpdate, Normal, Beta }

            public string LatestVersion{ get; set; }
            public string UpdateFileHanh { get; set; }
            public DateTime UpdateDateAvailable{ get; set; }
            //public bool IsBeta { get; set; }
            public UpdateTypeEnum UpdateType { get; set; }
        }


        public UpdaterForm(string currentVersion, bool considerBetas)
        {
            InitializeComponent();

            _boolConsiderBetas = considerBetas;
            _currentVersion = currentVersion;
        }

        private void B_Load(object sender, EventArgs e)
        {
            _wcDownloadFile.DownloadProgressChanged += _wcDownloadFile_DownloadProgressChanged;
            _wcDownloadFile.DownloadFileCompleted += _wcDownloadFile_DownloadFileCompleted;

            _strUpdateFolder = Path.GetDirectoryName(Application.ExecutablePath) + "\\Update\\";
            _strInstallFolder = Path.GetDirectoryName(Application.ExecutablePath);



            _appSettings = new ApplicationSettings();

        }

        private void _wcDownloadFile_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Update progress bars and also start downloading next file (if one exists)
            _intDownloadedAlready += _lstFilesToDownload[0].Size;

            AddStatus("File (" + Path.GetFileName(_lstFilesToDownload[0].DestinationFilename) + ") downloaded.");

            // remove file just downloaded
            _lstFilesToDownload.RemoveAt(0);

            DownloadNextFile();
        }

        private void _wcDownloadFile_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // update progress bars
            UpdateProgressBar((int)e.BytesReceived);
        }

        private void bgwCheckForUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // Check for new version
                SetStatus("Checking the server for updates.");

                VersionUpdateData objUpdateData = UpdateAvailable();


                // Before we download EVERY file needed, we must check if the Updater needs updating
                // if it does, then we must only download that, then replace the updater and re-launch (using updaterReplacer)
                string strUpdaterFilename = Path.GetFileName(Application.ExecutablePath).ToLower();
                string strSourceFilename;
                FileHashMatchesEnum needToDownload;

                XmlNodeList xList = _xSelectedVersion.SelectNodes("Files/File");
                foreach (XmlElement xFile in xList)
                {
                    //  Here we only need to check the updater because this branches the update logic (see comments above)
                    strSourceFilename = BASE_URL + xFile.GetAttribute("SourceLocation") + "/" + xFile.InnerText;

                     if (Path.GetFileName(strSourceFilename.ToLower()) == strUpdaterFilename)
                     {
                         needToDownload = FileNeedsToBeDownloaded(xFile.InnerText.Trim(), xFile.GetAttribute("Hash"));

                         switch (needToDownload)
                         {
                            case FileHashMatchesEnum.MatchDownloaded:
                                 // Do nothing here
                                 break;
                            case FileHashMatchesEnum.MatchInUse:
                                 // This should hit if updater needs replacing and gets relaunched (because 
                                 // updater will not need updating and it's the only file we care about)
                                 // Do nothing here
                                break;
                            case FileHashMatchesEnum.NoMatchDownload:
                                 // If we are here, then we know updater needs to be replaced
                                 // Remove all other files from the list
                                _boolUpdaterNeedUpdated = true;
                                 XmlElement xParent = (XmlElement)xFile.ParentNode;
                                 xParent.RemoveAll();
                                 xParent.AppendChild(xFile); // Now there should only be a single file to download: the updater
                                 break;
                         }
                     }
                }

                e.Result = objUpdateData;

            }
            catch (System.Net.WebException ex)
            {
                // Cannot connect
                SetStatus("Unable to connect to update server. Please try again later.");
            }
            catch (Exception ex)
            {
                SetStatus("There was an error checking for updates (" + ex.Message + ").\r\n\r\nPlease try again later.");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Stop();
            btnClose.Focus();
            bgwCheckForUpdate.RunWorkerAsync();
        }

        private delegate void SetStatusCallback(string message);
        private void SetStatus(string message)
        {
            if (this.InvokeRequired)
            {
                SetStatusCallback deleg = new SetStatusCallback(SetStatus);
                this.Invoke(deleg, new object[] { message });
            }
            else
            {
                txtStatus.Text = string.Empty;
                AddStatus(message);
                Application.DoEvents();
            }
        }
        private void AddStatus(string message)
        {
            if (this.InvokeRequired)
            {
                SetStatusCallback deleg = new SetStatusCallback(AddStatus);
                this.Invoke(deleg, new object[] { message });
            }
            else
            {
                Log(message);
                txtStatus.Text += Environment.NewLine + message;
                Application.DoEvents();
            }
        }
        private delegate void UpdateProgressBarsCallback(int fileProgress);
        private void UpdateProgressBar(int fileProgress)
        {
            if (this.InvokeRequired)
            {
                UpdateProgressBarsCallback deleg = new UpdateProgressBarsCallback(UpdateProgressBar);
                this.Invoke(deleg, new object[] { fileProgress });
            }
            else
            {
                prgCurrentFile.Value = fileProgress;
                prgOverall.Value = _intDownloadedAlready;
                Application.DoEvents();
            }

        }
        private delegate void SetProgressBarsCallback(int fileSize, int overallSize);
        private void SetProgressBars(int fileSize, int overallSize)
        {
            if (this.InvokeRequired)
            {
                SetProgressBarsCallback deleg = new SetProgressBarsCallback(SetProgressBars);
                this.Invoke(deleg, new object[] { fileSize, overallSize });
            }
            else
            {
                prgCurrentFile.Value = 0;
                prgCurrentFile.Maximum= fileSize;
                prgOverall.Maximum= overallSize;
                Application.DoEvents();
            }

        }

        private VersionUpdateData UpdateAvailable()
        {
            const string VERSION_FILENAME = BASE_URL + "Versions/TeachingAppVersionList.xml";
            const string RELEASE_DATE = "ReleaseDate";
            const string VERSION_NUMBER = "Number";

            VersionUpdateData objReturn = new VersionUpdateData();
            
            using (WebClient wc = new WebClient())
            {
                StreamReader sr = new StreamReader(wc.OpenRead(VERSION_FILENAME));
                string strContents, strServerVersion;
                strContents = sr.ReadToEnd();
                if (strContents.Length > 0)
                {
                    _xDocVersionData.LoadXml(strContents);
                    XmlNodeList xList = _xDocVersionData.SelectNodes("//Version");
                    if (xList.Count > 0)
                    {
                        foreach (XmlElement xVersion in xList)
                        {
                            strServerVersion = xVersion.GetAttribute(VERSION_NUMBER);

                            string strDate = xVersion.GetAttribute(RELEASE_DATE);
                            DateTime dtReleaseDate = Conversion.ConvertToDateFromXML(strDate, _dtDefault);
                            if (dtReleaseDate == _dtDefault)
                            {
                                // This is a pre-release or beta version
                                if (_boolConsiderBetas)
                                {
                                    objReturn.LatestVersion = strServerVersion;
                                    objReturn.UpdateDateAvailable = dtReleaseDate;
                                    _xSelectedVersion = xVersion;
                                    
                                    // This is the latest version but we must see if it is newer than the current version
                                    if(VersionIsSameOrLater(strServerVersion, _currentVersion))
                                    {
                                        // No need for an update, current version is the latest
                                        objReturn.UpdateType = VersionUpdateData.UpdateTypeEnum.NoUpdate;
                                        break;// I'm assuming this will break out of the foreach 
                                    }
                                    else
                                    {
                                        // Server version is newer
                                        objReturn.UpdateType = VersionUpdateData.UpdateTypeEnum.Beta;
                                        break;// I'm assuming this will break out of the foreach 
                                    }
                                }
                                else
                                {
                                    //We cannot use this one, keep looping around until we fine something better
                                    Application.DoEvents(); // for breakpoint
                                }
                            }
                            else
                            {
                                objReturn.LatestVersion = strServerVersion;
                                objReturn.UpdateDateAvailable = dtReleaseDate;
                                _xSelectedVersion = xVersion;

                                if (VersionIsSameOrLater(strServerVersion, _currentVersion))
                                {
                                    // No need for an update, current version is the latest
                                    objReturn.UpdateType = VersionUpdateData.UpdateTypeEnum.NoUpdate;
                                    break;// I'm assuming this will break out of the foreach 
                                }
                                else
                                {
                                    // Server version is newer
                                    // this is a regular release, we can use it regardless of beta setting by user
                                    objReturn.UpdateType = VersionUpdateData.UpdateTypeEnum.Normal;
                                    break;// I'm assuming this will break out of the foreach
                                }
                            }
                        }
                        _appSettings.DateLastChecked = DateTime.Now;
                        return objReturn;
                    }
                    // Too little returned from server (maybe temp problem)
                    objReturn.UpdateType = VersionUpdateData.UpdateTypeEnum.Unknown;
                    return objReturn;
                }
                else
                {
                    // nothing received from server
                    objReturn.UpdateType = VersionUpdateData.UpdateTypeEnum.Unknown;
                    return objReturn;
                }

            }

        }

        private void bgwCheckForUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            VersionUpdateData objUpdateData = (VersionUpdateData)e.Result;

            if (objUpdateData == null)
                return;// could not connect to update server

            string strUpdateDetails;

            if (objUpdateData.UpdateType == VersionUpdateData.UpdateTypeEnum.Beta)
                strUpdateDetails = Environment.NewLine + "Your current version: " + _currentVersion + Environment.NewLine + "Latest version: " + objUpdateData.LatestVersion + Environment.NewLine + "New version is a beta update, not yet available to all users.";
            else
                strUpdateDetails = Environment.NewLine + "Your current version: " + _currentVersion + Environment.NewLine + "Latest version: " + objUpdateData.LatestVersion + Environment.NewLine + "Date available to all users: " + objUpdateData.UpdateDateAvailable.ToString("dd MMMM yyyy");

            switch (objUpdateData.UpdateType)
            {
                case VersionUpdateData.UpdateTypeEnum.Unknown:
                    SetStatus("The server could not be contacted. Please try again later." + Environment.NewLine + strUpdateDetails);
                    btnClose.Focus();
                    break;
                case VersionUpdateData.UpdateTypeEnum.NoUpdate:
                    SetStatus("You are using the most current version." + Environment.NewLine + strUpdateDetails);
                    btnClose.Focus();
                    break;
                case VersionUpdateData.UpdateTypeEnum.Normal:
                case VersionUpdateData.UpdateTypeEnum.Beta:
                    if (_boolUpdaterNeedUpdated)
                        SetStatus("The update utility must be replaced before you can update to the latest version. Click the Download button to download it now." + Environment.NewLine + strUpdateDetails);
                    else
                        SetStatus("There is a recommended update available. Click the Download button to download it now." + Environment.NewLine + strUpdateDetails);
                    EnableDownload();
                    break;
            }

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                SetStatus("Downloading the latest version.");
                prgCurrentFile.Visible = true;
                prgOverall.Visible = true;
                lblCurrent.Visible = true;
                lblOverall.Visible = true;
                btnDownload.Enabled = false;
                btnClose.Focus();
                _intDownloadedAlready = 0;
                Application.DoEvents();

                bgwDownloadUpdate.RunWorkerAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void bgwDownloadUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string strSourceFilename, strDestinationFilename;
                FileHashMatchesEnum needToDownload;

                // Ensure update folder exists
                if (!Directory.Exists(_strUpdateFolder))
                    Directory.CreateDirectory(_strUpdateFolder);

                _intTotalToDownload = 0; // Need to reset for re-download

                
                XmlNodeList xList = _xSelectedVersion.SelectNodes("Files/File");
                foreach (XmlElement xFile in xList)
                {
                    //  Download each file to the holding directly
                    strSourceFilename = BASE_URL + xFile.GetAttribute("SourceLocation") + "/" + xFile.InnerText;
                    strDestinationFilename = _strUpdateFolder + xFile.InnerText;


                    // See if the file has been downloaded already
                    // it could even be in use already (part of the current version)
                    needToDownload = FileNeedsToBeDownloaded(xFile.InnerText.Trim(), xFile.GetAttribute("Hash"));

                    switch (needToDownload)
                    {
                        case FileHashMatchesEnum.MatchDownloaded:
                            // no need to download, it was downloaded already and we have the right version
                            // just need to install it
                            break;
                        case FileHashMatchesEnum.MatchInUse:
                            // The current version (in use) is already correct, remove from update list
                            // so we don't download when not needed
                            xFile.ParentNode.RemoveChild(xFile);
                            break;
                        case FileHashMatchesEnum.NoMatchDownload:
                            // Download from the server
                            //  actually just queue up so we can download asynch to keep the progress bars updated
                            FileDownloadData file = new FileDownloadData();
                            file.SourceFilename = strSourceFilename + ".bin";
                            file.DestinationFilename = strDestinationFilename;
                            file.Size = Convert.ToInt32(xFile.GetAttribute("Size"));
                            file.Hash = xFile.GetAttribute("Hash");
                            _intTotalToDownload += file.Size;
                            _lstFilesToDownload.Add(file);
                            break;
                    }

                }

            }
            catch(IOException ex)
            {
                AddStatus(string.Empty);
                AddStatus(ex.Message);
                AddStatus(string.Empty);
                AddStatus("Please try to correct the problem and download again.");
                _lstFilesToDownload.Clear(); // we don't want to add multiple copies of any files
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private enum FileHashMatchesEnum { MatchDownloaded, MatchInUse, NoMatchDownload}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename">The name of the file to check (ex: test.txt)</param>
        /// <param name="hashExpected">The expected hash value of the file</param>
        /// <returns></returns>
        private FileHashMatchesEnum FileNeedsToBeDownloaded(string filename, string hashExpected)
        {
            string strDestinationFilename;

            // first check the update folder to see if we downloaded it already
            strDestinationFilename = Path.Combine(_strUpdateFolder, filename);

            if (File.Exists(strDestinationFilename))
            {
                if (Hashing.HashMatches(hashExpected, Hashing.GetFileHash(strDestinationFilename)))
                    return FileHashMatchesEnum.MatchDownloaded; // exists and hash value matches
                else
                {
                    // exists but hash value is different, keep searching
                }
            }
            else
            {
                // does not even exist, keep searching
            }


            // next check the application folder to see if we are using the current version of the file
            strDestinationFilename = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), filename);

            if (File.Exists(strDestinationFilename))
            {
                if (Hashing.HashMatches(hashExpected, Hashing.GetFileHash(strDestinationFilename)))
                    return FileHashMatchesEnum.MatchInUse; // exists and hash value matches
                else
                    return FileHashMatchesEnum.NoMatchDownload; // exists but hash value is different, download it
            }
            else
                return FileHashMatchesEnum.NoMatchDownload; // does not even exist, download it



        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename">Full path to the file to check (ex: c:\temp\test.txt)</param>
        /// <param name="hashExpected">The expected hash value of the file</param>
        /// <returns></returns>
        private bool FileHasExpectedHashValue(string filename, string hashExpected)
        {
            if (File.Exists(filename))
            {
                if (Hashing.HashMatches(hashExpected, Hashing.GetFileHash(filename)))
                    return true; // exists and hash value matches
                else
                    return false; // exists but hash value is different
            }
            else
                return false; // does not even exist
        }
        
        private void tmrDownloadAsynch_Tick(object sender, EventArgs e)
        {
            tmrDownloadAsynch.Stop();
            DownloadNextFile();

            // progress bars update on wc_progressChanged event so nothing to do here
        }

        private void DownloadNextFile()
        {
            if (_lstFilesToDownload.Count == 0)
            {
                // If there are no more files, time to install
                GetReadyToInstall();
            }
            else
            {
                FileDownloadData file = _lstFilesToDownload[0];

                // get the next file
                SetProgressBars(file.Size, _intTotalToDownload);
                AddStatus("Downloading " + Path.GetFileName(file.DestinationFilename));
                _wcDownloadFile.DownloadFileAsync(new Uri( file.SourceFilename), file.DestinationFilename);
            }
        }


        private void bgwDownloadUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                // there was a problem, just allow user to download again
                EnableDownload();
            }
            else
            {
                // Now we have a list of files to download
                prgOverall.Maximum = _intTotalToDownload;
                tmrDownloadAsynch.Start();
            }
        }

        /// <summary>
        /// Verify that all files are downloaded and the hashes match
        /// </summary>
        private void GetReadyToInstall()
        {
            try
            {
                bool boolOKToInstall = true; // assume all is fine and ready to install

                SetStatus("Verifying downloads.");

                XmlNodeList xList = _xSelectedVersion.SelectNodes("Files/File");
                foreach (XmlElement xFile in xList)
                {
                    //  Download each file to the holding directly
                    switch (FileNeedsToBeDownloaded(xFile.InnerText, xFile.GetAttribute("Hash")))
                    {
                        case FileHashMatchesEnum.MatchDownloaded:
                            AddStatus("File is clean: " + xFile.InnerText);
                            break;// nothing to do
                        case FileHashMatchesEnum.MatchInUse:
                            // if element is here (should have been removed in Download_DoWork)
                            // then we must remove it now
                            AddStatus("File is clean and present: " + xFile.InnerText);
                            xFile.ParentNode.RemoveChild(xFile);
                            break;
                        case FileHashMatchesEnum.NoMatchDownload:
                            AddStatus("File is corrupt: " + xFile.InnerText);
                            boolOKToInstall = false;
                            break; // no need to keep checking. One problem means must run download process again
                    }
                }
                if (boolOKToInstall)
                {
                    // Everything seems fine, enable the install button
                    EnableInstall();
                    SetStatus("The update is ready. Please click the Install button.");
                }
                else
                {
                    // Something is wrong, either something didn't come down or the hash doesn't match
                    EnableDownload();
                    AddStatus(string.Empty);
                    AddStatus("The download did not complete properly.\r\n\r\nPlease click the download button again.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        private delegate void VoidEmptyCallback();
        private void EnableInstall()
        {
            if (InvokeRequired)
            {
                VoidEmptyCallback deleg = new VoidEmptyCallback(EnableInstall);
                Invoke(deleg, new object[] { });
            }
            else
            {
                btnInstall.Enabled = true;
                btnInstall.Focus();
                btnDownload.Enabled = false;

                lblCurrent.Visible = false;
                lblOverall.Visible = false;
                prgCurrentFile.Visible = false;
                prgOverall.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            SetStatus("Installing updates...please wait.");
            bgwInstallUpdate.RunWorkerAsync();
        }

        private void bgwInstallUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            // Need to install in a way that if ther are any problems
            // we can rollback
            try
            {
                using (TransactionalFileChanges trans = new TransactionalFileChanges())
                {
                    try
                    {
                        string strSourceFilename, strDestinationFilename;

                        XmlNodeList xList = _xSelectedVersion.SelectNodes("Files/File");
                        foreach (XmlElement xFile in xList)
                        {
                            strSourceFilename = Path.Combine(_strUpdateFolder,  xFile.InnerText);
                            strDestinationFilename = Path.Combine(_strInstallFolder, xFile.InnerText);

                            if (strDestinationFilename == System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName))
                            {
                                AddStatus("Updating updater...need replacer.");

                            }
      
                            if (TransactionalFileChanges.IsRunningProcess(strDestinationFilename))
                            {
                                AddStatus("Please close the following: " + System.IO.Path.GetFileNameWithoutExtension(xFile.InnerText));
                                AddStatus("Then try to install the update again.");
                                throw new Exception("File in use and cannot be overwritten.");
                            }

                            AddStatus("Updating " + xFile.InnerText);

                            // move each file from update folder to App folder
                            Log("About to move file. Source=" + strSourceFilename + "; Destination=" + strDestinationFilename);
                            trans.MoveFile(strSourceFilename, strDestinationFilename);
                            Log("Just moved file. Source=" + strSourceFilename + "; Destination=" + strDestinationFilename);

                            if (System.IO.File.Exists(strSourceFilename))
                                Log("Source is there (should not be). Source=" + strSourceFilename);

                            if (!System.IO.File.Exists(strDestinationFilename))
                                Log("Destination is not there (should be). Destination=" + strDestinationFilename);
                        }

                        // If we did not throw any errors, we should be fine, so commit
                        trans.CommitTransaction();
                        Log("Just committed transaction.");
                    }
                    catch (Exception ex)
                    {
                        Log("Error stacktrace: " + ex.StackTrace);
                        Log("Error: " + ex.Message + " - expecting auto-rollback.");
                        // The transaction should roll itself back automatically
                        // still need to notify the user
                        AddStatus(string.Empty);
                        if (ex.InnerException != null)
                            AddStatus(ex.InnerException.Message);
                        e.Cancel = true;
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bgwInstallUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                AddStatus(string.Empty);
                AddStatus("Please correct the problem and install again.");
                EnableInstall();
            }
            else
            {
                SetStatus("Update completed successfully.");
                btnDownload.Visible = false;
                btnInstall.Visible = false;
                btnClose.Focus();
            }
        }
        /// <summary>
        /// Returns true if currentVersion has the same or a later version as serverVersion (so no need to update if true)
        /// </summary>
        /// <param name="serverVersion">Version available on the server</param>
        /// <param name="currentVersion">Version currently being used</param>
        /// <returns></returns>
        private bool VersionIsSameOrLater(string serverVersion, string currentVersion)
        {
            Log("Checking version. Server version=" + serverVersion + "; Current Version=" + currentVersion);

            // 1.0.0 vs. 1.2.3
            int intMajor1, intMinor1, intRevision1;
            int intMajor2, intMinor2, intRevision2;
            const string VERSION_DELIMITER=".";
            int intStartPos1=0;
            int intStartPos2=0;
            int intEndPos1=serverVersion.IndexOf(VERSION_DELIMITER);
            int intEndPos2=currentVersion.IndexOf(VERSION_DELIMITER);

            intMajor1=Convert.ToInt32(serverVersion.Substring(intStartPos1, intEndPos1));
            intMajor2=Convert.ToInt32(currentVersion.Substring(intStartPos2, intEndPos2));

            if (intMajor2>intMajor1)
                return true; // major smaller (4.x vs 3.x) so no need to check more
            else if (intMajor2>intMajor1)
                return false; // major smaller (4.x vs 5.x) so no need to check more

            intStartPos1=intEndPos1+1;
            intStartPos2=intEndPos2+1;
            intEndPos1=serverVersion.IndexOf(VERSION_DELIMITER,intStartPos1);
            intEndPos2=currentVersion.IndexOf(VERSION_DELIMITER, intStartPos2);

            intMinor1 = Convert.ToInt32(serverVersion.Substring(intStartPos1, intEndPos1 - intStartPos1));
            intMinor2 = Convert.ToInt32(currentVersion.Substring(intStartPos2, intEndPos2 - intStartPos2));
        
            if(intMinor2>intMinor1)
                return true;
            else if(intMinor2<intMinor1)
                return false;

            intStartPos1 = intEndPos1 + 1;
            intStartPos2 = intEndPos2 + 1;

            intRevision1 = Convert.ToInt32(serverVersion.Substring(intStartPos1));
            intRevision2 = Convert.ToInt32(currentVersion.Substring(intStartPos2));

            if(intRevision2 >= intRevision1)
                return true;
            else
                return false;
        }

        private void EnableDownload()
        {
            if (InvokeRequired)
            {
                VoidEmptyCallback deleg = new VoidEmptyCallback(EnableDownload);
                Invoke(deleg, new object[] { });
            }
            else
            {
                btnInstall.Enabled = false;
                btnDownload.Enabled = true;
                btnDownload.Focus();

                lblCurrent.Visible = false;
                lblOverall.Visible = false;
                prgCurrentFile.Visible = false;
                prgOverall.Visible = false;
            }
        }

        private void UpdaterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _appSettings.Save();
        }
        private void Log(string text)
        {
            string strLogFilename ;
            strLogFilename = Path.GetDirectoryName(Application.ExecutablePath);
            strLogFilename = Path.GetDirectoryName(strLogFilename);// go up one level to get to launcher
            if(!strLogFilename.EndsWith("\\"))
                strLogFilename += "\\";
            strLogFilename  += "Data\\Log.txt";

            System.IO.File.AppendAllText(strLogFilename, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  " + text + Environment.NewLine);

        }
    }
}
