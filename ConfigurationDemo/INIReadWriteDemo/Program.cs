using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INIReadWriteDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            const string SECTION = "Section1";
            const string KEY = "KeyWord1";

            INIHelper helper = new INIHelper(@"..\..\test.ini");
            helper.PrintFilePath();

            string orginal = helper.GetValue(SECTION, KEY);

            Console.WriteLine(string.Format("Orginal value for [{0}]:[{1}] is {2}", SECTION,KEY,orginal));

            Random r = new Random();
            string newValue = "Value" + r.Next(5, 10);
            helper.WriteValue(SECTION, KEY, newValue);

            Console.WriteLine(string.Format("value for [{0}]:[{1}] is changed from {2} to {3}", SECTION, KEY, orginal, newValue));

            orginal = helper.GetValue(SECTION, KEY);

            Console.WriteLine(string.Format("Orginal value for [{0}]:[{1}] is {2}", SECTION, KEY, orginal));

            Console.ReadLine();
        }
    }
}
