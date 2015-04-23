using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Backtrack");
            Queen q = new Queen();
            q.Test();

            Console.WriteLine("Recursive Queen2");
            Queen2 q2 = new Queen2();
            q2.Test();

            Console.WriteLine("Recursive Queen3");
            Queen3 q3 = new Queen3();
            q3.Test();

            Console.WriteLine("Recursive Queen4");
            Queen4 q4 = new Queen4();
            q4.Test();

            Console.Read();
        }
    }
}
