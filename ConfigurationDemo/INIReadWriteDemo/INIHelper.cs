using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace INIReadWriteDemo
{
    public class INIHelper
    {
        [DllImport("kernel32")]
        //def：无法读取时候时候的缺省数值；
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        public string INIFile { get; set; }

        public INIHelper(string iniFile)
        {
            this.INIFile = iniFile;
        }

        public void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, this.INIFile);
        }

        public string GetValue(string section, string key)
        {
            StringBuilder sbValue = new StringBuilder(1024);
            GetPrivateProfileString(section, key, "DEAULT", sbValue, 1024, this.INIFile);
            return sbValue.ToString();
        }

        public void PrintFilePath()
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(this.INIFile);
            Console.WriteLine(fi.FullName);
        }
    }
}
