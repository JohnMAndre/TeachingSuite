using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Teaching
{
    class ApplicationSettings
    {
        private const String DATE_TIME_FORMAT_XML = "yyyy-MM-ddTHH:mm:00";

        #region Public properties
        public DateTime DateLastChecked { get; set; }
        
        #endregion

                public ApplicationSettings()
        {
            try 
            {	        
	            if(File.Exists(GetSettingsFilename()))
                {
                    XmlDocument xDoc=new XmlDocument();
                    xDoc.Load(GetSettingsFilename());
                    XmlElement xElement = (XmlElement)xDoc.SelectSingleNode("//DateLastChecked");
                    if (xElement != null)
                        DateLastChecked = Conversion.ConvertToDateFromXML(xElement.InnerText, DateTime.Now);
                    else
                        DateLastChecked = DateTime.Now;

                }
                else
                {
                    // Setup defaults
                    DateLastChecked = DateTime.Now;
                }
            }
	        catch (Exception ex)
	        {
		        throw ex;
	        }

        }
        public void Save()
        {
            // Save back to Data folder
            try 
	        {	
	            XmlDocument xDoc=new XmlDocument();
	            xDoc.AppendChild(xDoc.CreateElement("settings"));
                xDoc.DocumentElement.AppendChild(GetSettingsNode(xDoc, "DateLastChecked", DateLastChecked));

                xDoc.Save(GetSettingsFilename());

	        }
	        catch (Exception)
	        {
		        throw;
	        }

        }
        private XmlElement GetSettingsNode(XmlDocument xDoc, string name, object value)
        {
            XmlElement xElement = xDoc.CreateElement(name);
            switch(Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.DateTime:
                    xElement.InnerText = ((DateTime)value).ToString(DATE_TIME_FORMAT_XML);
                    break;
                default:
                    xElement.InnerText = value.ToString();
                    break;
            }
            return xElement;
        }

        private string GetSettingsFilename()
        {
            const string SETTINGS_FILENAME = "UpdaterSettings.xml";
            return Path.Combine(GetDataFolder(), SETTINGS_FILENAME);
        }

        private string GetDataFolder()
        {
            const string SETTINGS_FOLDER="Data";
            Path.GetDirectoryName(Application.ExecutablePath);

            DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(Application.ExecutablePath));
            di = di.Parent;

            string strPath = di.FullName;

            if(!strPath.EndsWith("\\"))
                strPath+="\\";
            strPath+=SETTINGS_FOLDER;

            if (!Directory.Exists(strPath))
                Directory.CreateDirectory(strPath);

            return strPath;
            
        }
    }
}
