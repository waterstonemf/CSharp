/*This demo shows how to read configfile by XmlSerializer.Serialize() and Deserialize()
 * one note is how to define the class format: declare subclass as the property of the main class.
 * 
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace SerializeDeserializeDemo
{
    class Program
    {
        static string CONFIG_FILE = "MyConfigInfo.xml";
        static void Main(string[] args)
        {
            Save(CONFIG_FILE);
            Load(CONFIG_FILE);

            Console.ReadLine();
        }

        static void Save(string configFile)
        {
            ConfigInfo ci = new ConfigInfo();
            ci.ConfigName = "My Config File";
            ci.CreatedTime = DateTime.Now;

            ci.ConfigItems = new List<KeyValuePair<string, string>>();

           // KeyValuePair<string, string> item = new KeyValuePair<string, string>("Name", "Zhang San");

            //no values in the xml
            ci.ConfigItems.Add(new KeyValuePair<string, string>("Name", "Zhang San"));
            ci.ConfigItems.Add(new KeyValuePair<string, string>("Age", "30"));
            ci.ConfigItems.Add(new KeyValuePair<string, string>("Sex", "Male"));

            //the node name is string instead of Name1, Name2, Name3
            ci.ConfigNames = new List<string>();
            string Name1 = "AAAA";
            string Name2 = "BBBB";
            string Name3 = "CCCC";
            ci.ConfigNames.AddRange(new string[]{Name1,Name2,Name3});

            //kind of what I want ,the node have node name and value
            ci.ConfigItemList = new List<ConfigItem>();
            ci.ConfigItemList.AddRange(new ConfigItem[] { new ConfigItem() { Name = "Item1", Value = "Value1" }, new ConfigItem() { Name = "Item2", Value = "Value2" }, new ConfigItem() { Name = "Item3", Value = "Value3" } });


            //but this is the real foramt I want: must declare subclass as the property of the main class, so easy
            ci.SubAppInfo = new AppInfo() { AppName = "Who Knows", AppVersion = "1.1.1", Authors = "Zhang San, Lisi,Wang Mazi", CopyRightYear = 2015 };

            XmlSerializer ser = new XmlSerializer(typeof(ConfigInfo));
            using (StreamWriter sw = new StreamWriter(configFile,false,Encoding.UTF8))
            {
                ser.Serialize(sw, ci);
            }

            Console.WriteLine("Save Done!");
        }

        static void Load(string configFile)
        {
            XmlSerializer ser = new XmlSerializer(typeof(ConfigInfo));
            ConfigInfo myConfig = null;
            using (StreamReader sr = new StreamReader(configFile, Encoding.UTF8))
            {
                myConfig = ser.Deserialize(sr) as ConfigInfo;
            }

            if(myConfig != null)
            {
                Console.WriteLine(myConfig.CreatedTime);
                Console.WriteLine(myConfig.SubAppInfo.Authors);
            }
        }
        
    }
}
