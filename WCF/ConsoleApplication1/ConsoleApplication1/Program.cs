using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            B a = new B();
            A b = new A();
            Console.ReadLine();
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
    }

    class B:A
    {
        public B()
        {
            Console.WriteLine("B");
        }
    }


}
