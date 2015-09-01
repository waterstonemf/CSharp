using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrayAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            int[] b = a;   // no error here, but a and b just refer to the same array object

            foreach (int i in a)
            {
                Console.WriteLine(i.ToString());
            }

            foreach(int i in b)
            {
                Console.WriteLine(i.ToString());
            }

            b[0] = 100;


            foreach (int i in a)
            {
                Console.WriteLine(i.ToString());
            }

            foreach (int i in b)
            {
                Console.WriteLine(i.ToString());
            }

            Console.ReadLine();

        }
    }
}
