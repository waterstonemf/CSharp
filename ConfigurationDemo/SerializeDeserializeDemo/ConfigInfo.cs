using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserializeDemo
{
    public class ConfigInfo
    {
        public string ConfigName { get; set; }
        public DateTime CreatedTime { get; set; }
       // private List<KeyValuePair<string,string>> _configItems = new List<KeyValuePair<string,string>>();
        public List<KeyValuePair<string, string>> ConfigItems
        {
            get;
            set;
        }

        public List<string> ConfigNames
        {
            get;
            set;
        }

        public List<ConfigItem> ConfigItemList { get; set; }

        public AppInfo SubAppInfo { get; set; }
    }


    public class ConfigItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class AppInfo
    {
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public int CopyRightYear { get; set; }
        public string Authors { get; set; }
    }
    
}
