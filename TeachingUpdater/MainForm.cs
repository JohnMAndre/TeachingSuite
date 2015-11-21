using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace TeachingUpdater
{

    public partial class B : Form
    {
        private bool _boolConsiderBetas;

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
            catch (Exception ex)
            {

                throw ex;
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

        private VersionUpdateData UpdateAvailable()
        {
            const string VERSION_FILENAME = "http://trulymail.com/TeachingApp/Versions/TeachingAppVersionList.xml";
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
                    XmlDocument xDocVersions = new XmlDocument();
                    xDocVersions.LoadXml(strContents);
                    XmlNodeList xList = xDocVersions.SelectNodes("//Version");
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

            string strUpdateDetails;

            if (objUpdateData.UpdateType == VersionUpdateData.UpdateTypeEnum.Beta)
                strUpdateDetails = Environment.NewLine + "Your current version: " + Application.ProductVersion + Environment.NewLine + "Latest version: " + objUpdateData.LatestVersion + Environment.NewLine + "New version is a beta update, not yet available to all users.";
            else
                strUpdateDetails = Environment.NewLine + "Your current version: " + Application.ProductVersion + Environment.NewLine + "Latest version: " + objUpdateData.LatestVersion + Environment.NewLine + "Date available to all users: " + objUpdateData.UpdateDateAvailable.ToString("dd-MMMM-yyyy");

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
                    btnDownload.Enabled = true;
                    btnDownload.Focus();
                    break;
            }

        }
    }
}
