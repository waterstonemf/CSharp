using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s = new Student("AAA");
            s.Score = 10;
            Console.WriteLine(s.GetMyScore());

            Console.Read();
        }
    }
}
