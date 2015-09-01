using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemo
{
    public class Student
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public Student(string name)
        {
            this.Name = name;
        }

    }
}
