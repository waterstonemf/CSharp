using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NumberScreenRollingDown
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Currently 5 sample supported! Please input 1 to 5 to choose the sample you want to see.");
                string sample = Console.ReadLine();
                int wayIndex = 0;
                IWay way = null;
                if (int.TryParse(sample, out wayIndex))
                {
                    switch (wayIndex)
                    {
                        case 1: way = new Way1(); break;
                        case 2: way = new Way2(); break;
                        case 3: way = new Way3(); break;
                        case 4: way = new Way4(); break;
                        case 5: way = new Way5(); break;
                        default: Console.WriteLine("Not Supported : " + sample); break;
                    }

                    if (way != null)
                    {
                        way.Print();
                        done = true;
                    }

                    
                }
                else
                {
                    Console.WriteLine("Invalid Inputs: Only Numbers 1 - 5 are allowed");
                }
            }

            Console.Read();
        }

        
    }
}
