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

namespace TeachingUpdater
{

    public partial class B : Form
    {
        private class FileDownloadData
        {
            public string SourceFilename { get; set; }
            public string DestinationFilename{ get; set; }
            public int Size { get; set; }
            public string Hash { get; set; }
        }

        private bool _boolConsiderBetas;
        private int _intTotalToDownload, _intDownloadedAlready;
        private XmlDocument _xDocVersionData = new XmlDocument();
        private XmlElement _xSelectedVersion;
        private string _strUpdateFolder;
        private string _strInstallFolder;

        private const string BASE_URL = "http://trulymail.com/TeachingApp/";
        private List<FileDownloadData> _lstFilesToDownload = new List<FileDownloadData>() ;
        private WebClient _wcDownloadFile = new WebClient();
        private bool _boolDownloading;

        public class VersionUpdateData
        {
            public enum UpdateTypeEnum { Unknown, NoUpdate, Normal, Beta }

            public string LatestVersion{ get; set; }
            public string UpdateFileHanh { get; set; }
            public DateTime UpdateDateAvailable{ get; set; }
            //public bool IsBeta { get; set; }
            public UpdateTypeEnum UpdateType { get; set; }
        }


        public B()
        {
            InitializeComponent();
        }

        private void B_Load(object sender, EventArgs e)
        {
            _wcDownloadFile.DownloadProgressChanged += _wcDownloadFile_DownloadProgressChanged;
            _wcDownloadFile.DownloadFileCompleted += _wcDownloadFile_DownloadFileCompleted;

            _strUpdateFolder = Path.GetDirectoryName(Application.ExecutablePath) + "\\Update\\";
            _strInstallFolder = Path.GetDirectoryName(Application.ExecutablePath);

        }

        private void _wcDownloadFile_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Update progress bars and also start downloading next file (if one exists)
            _intDownloadedAlready += _lstFilesToDownload[0].Size;

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
                txtStatus.Text = message;
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

            DateTime dtDefault = new DateTime(2010, 1, 1);
            VersionUpdateData objReturn = new VersionUpdateData();
            
            using (WebClient wc = new WebClient())
            {
                StreamReader sr = new StreamReader(wc.OpenRead(VERSION_FILENAME));
                string strContents;
                strContents = sr.ReadToEnd();
                if (strContents.Length > 0)
                {
                    _xDocVersionData.LoadXml(strContents);
                    XmlNodeList xList = _xDocVersionData.SelectNodes("//Version");
                    if (xList.Count > 0)
                    {
                        foreach (XmlElement xVersion in xList)
                        {
                            string strDate = xVersion.GetAttribute(RELEASE_DATE);
                            DateTime dtTest = Conversion.ConvertToDateFromXML(strDate, dtDefault);
                            if (dtTest == dtDefault)
                            {
                                // This is a pre-release or beta version
                                if (_boolConsiderBetas)
                                {
                                    objReturn.LatestVersion = xVersion.GetAttribute(VERSION_NUMBER);
                                    objReturn.UpdateDateAvailable = dtDefault;
                                    objReturn.UpdateType = VersionUpdateData.UpdateTypeEnum.Beta;
                                    _xSelectedVersion = xVersion;
                                    break;// I'm assuming this will break out of the foreach 
                                }
                                else
                                {
                                    //We cannot use this one, keep looping around until we fine something better
                                    Application.DoEvents(); // for breakpoint
                                }
                            }
                            else
                            {
                                // this is a regular release, we can use it regardless of beta setting by user
                                objReturn.LatestVersion = xVersion.GetAttribute(VERSION_NUMBER);
                                objReturn.UpdateDateAvailable = dtTest;
                                objReturn.UpdateType = VersionUpdateData.UpdateTypeEnum.Normal;
                                _xSelectedVersion = xVersion;
                                break;// I'm assuming this will break out of the foreach
                            }
                        }
                        return objReturn;
                    }
                    // Too little returned from server (maybe temp problem
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
                strUpdateDetails = Environment.NewLine + "Your current version: " + Application.ProductVersion + Environment.NewLine + "Latest version: " + objUpdateData.LatestVersion + Environment.NewLine + "New version is a beta update, not yet available to all users.";
            else
                strUpdateDetails = Environment.NewLine + "Your current version: " + Application.ProductVersion + Environment.NewLine + "Latest version: " + objUpdateData.LatestVersion + Environment.NewLine + "Date available to all users: " + objUpdateData.UpdateDateAvailable.ToString("dd MMMM yyyy");

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
                AddStatus(ex.Message);
                AddStatus("Please try to correct the problem and download again.");
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
            if(_boolDownloading)
            {
                // do nothing, we are still downloading the previous file
                // progress bars update on wc_progressChanged event so nothing to do here
                Application.DoEvents(); // for breakpoint only
            }
            else
            {
                // time to get the next file
                DownloadNextFile();
            }
        }

        private void DownloadNextFile()
        {
            _boolDownloading = true;

            if (_lstFilesToDownload.Count == 0)
            {
                // If there are no more files, then stop the timer
                tmrDownloadAsynch.Stop();

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
                _boolDownloading = false;
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
                string strDestinationFilename;
                bool boolNeedToDownload;
                bool boolOKToInstall = true;

                SetStatus("Verifying downloads.");

                XmlNodeList xList = _xSelectedVersion.SelectNodes("Files/File");
                foreach (XmlElement xFile in xList)
                {
                    //  Download each file to the holding directly
                    switch (FileNeedsToBeDownloaded(xFile.InnerText, xFile.GetAttribute("Hash")))
                    {
                        case FileHashMatchesEnum.MatchDownloaded:
                            break;
                        case FileHashMatchesEnum.MatchInUse:
                            break;
                        case FileHashMatchesEnum.NoMatchDownload:
                            boolOKToInstall = false;
                            break; // no need to keep checking. one problem means must run download process again
                    }
                    //strDestinationFilename = _strUpdateFolder + xFile.InnerText;

                    //// See if the file has been downloaded already
                    //if (File.Exists(strDestinationFilename))
                    //{
                    //    // If downloaded already, check to see if the hash matches to avoid re-downloading unnecessarily
                    //    if (Hashing.HashMatches(xFile.GetAttribute("Hash"), Hashing.GetFileHash(strDestinationFilename)))
                    //        boolNeedToDownload = false;
                    //    else
                    //        boolNeedToDownload = true;
                    //}
                    //else
                    //    boolNeedToDownload = true;


                    //// Download from the server
                    ////  actually just queue up so we can download asynch to keep the progress bars updated
                    //if (boolNeedToDownload)
                    //{
                    //}
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
                    SetStatus("The download did not complete properly.\r\n\r\nPlease click the download button again.");
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

                            AddStatus("Updating " + xFile.InnerText);

                            // move each file from update folder to App folder
                            trans.MoveFile(strSourceFilename, strDestinationFilename);
                        }

                        // If we did not throw any errors, we should be fine, so commit
                        trans.CommitTransaction();
                    }
                    catch (Exception ex)
                    {
                        // The transaction should roll itself back automatically
                        // still need to notify the user
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
                AddStatus("Please correct the problem and install again.");
                EnableInstall();
            }
            else
            {
                SetStatus("Update completed successfully.");
                btnInstall.Visible = false;
                btnClose.Focus();
            }
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
    }
}
