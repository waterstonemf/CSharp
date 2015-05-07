using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace LearningChinese
{
    class ConfigUtil
    {
        public const string DICTIONAY_FILE = "Dictionary.xml";

        public static void SaveDictionay(Dictionary d)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Dictionary));
            using (StreamWriter sw = new StreamWriter(DICTIONAY_FILE, false, Encoding.UTF8))
            {
                ser.Serialize(sw, d);
            }
        }


        public static Dictionary LoadDictionay()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Dictionary));
            Dictionary d = null;
            using (StreamReader sr = new StreamReader(DICTIONAY_FILE, Encoding.UTF8))
            {
                d = ser.Deserialize(sr) as Dictionary;
            }

            return d;
        }
    }
}
