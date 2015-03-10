using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumberScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Random r = new Random();
            int num = r.Next(9);

            while (true)
            {
                for (int i = 0; i < Console.WindowWidth - 1; i++)
                {
                    Console.Write(num.ToString());
                    num = r.Next(9);
                }
                Console.WriteLine(num);
                num = r.Next(9);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
