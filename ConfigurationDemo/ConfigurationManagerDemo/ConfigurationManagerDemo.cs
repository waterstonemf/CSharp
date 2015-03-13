/*
 * Note: 
 * 1) you must add using System.Configuration namespace and System.Configuration.dll reference, otherwise , you may not see Configuration class
 * 2) when you debug the exe in visual studio directly, it's in fact *.vshost.exe and *.vshost.exe.config is running. so the config modification will be in *.vshost.exe.config
 * to see the effect, do not debug in vs directly, instead, going to the bin folder and run exe there manually.
 * 
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;


namespace ConfigurationManagerDemo
{
    public class ConfigurationManagerDemo
    {
        private const string KEY_MAX_RETRY = "MaxRetry";

        public void Show()
        {
           Load();
            Write();

            Random r = new Random();

            AddNewKey("Key" + r.Next(1, 10).ToString(), r.Next(1, 1000).ToString());

            WriteAsXml(KEY_MAX_RETRY,r.Next(1,100).ToString());
        }

        public void Load()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //since Configuraiton class has a AppSettings property, so it will be very easy to access the configuration if you put them under appsettings node
            Console.WriteLine(string.Format("PlayerQueue:{0}", config.AppSettings.Settings["PlayerPoisonQueue"].Value));
            Console.WriteLine("Load Finished");
        }


        //this does work
        public void Write()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["MaxRetry"].Value = "6";
            config.Save(ConfigurationSaveMode.Modified);
            Console.WriteLine("Write Finished");
        }

        public void AddNewKey(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if(config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }

            config.Save(ConfigurationSaveMode.Modified);
            Console.WriteLine("Add NewKey finished");
        }

        //take the config file as a noremal xml file and read/write them
        public void WriteAsXml(string key, string value)
        {
            Console.WriteLine("Enter in WriteAsXml");
            XmlDocument doc = new XmlDocument();
            string fileName = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            Console.WriteLine(string.Format("Config File:{0}",fileName));

            doc.Load(fileName);

            XmlNodeList nodes = doc.GetElementsByTagName("add");
            string originalValue = string.Empty;
            foreach (XmlNode node in nodes)
            {
                XmlAttribute att = node.Attributes["key"];
                if(att.Value == key)
                {
                    att = node.Attributes["value"];
                    originalValue = att.Value;
                    att.Value = value;
                    break;
                }
            }

            doc.Save(fileName);

            try
            {
                //this will cuase exception since ConfigurationManager does not know our customized sharedListeners
                ConfigurationManager.RefreshSection("appSettings");
            }catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Exception:{0}",e.ToString()));
                Console.ResetColor();
            }

            Console.WriteLine(string.Format("value of the key {0} is changed from {1} to {2}", key, originalValue, value));

        }
        
    }
}
