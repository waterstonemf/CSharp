using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NumberScreenRollingDown
{
    class Way2 : IWay
    {
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;


            Thread t1 = new Thread(Print1);
            Thread t2 = new Thread(Print2);
            Thread t3 = new Thread(Print3);
            Thread t4 = new Thread(Print4);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

        }

        public void Print1()
        {
            PrintCommon(1);
        }

        public void Print2()
        {
            PrintCommon(2);
        }

        public void Print3()
        {
            PrintCommon(3);
        }

        public void Print4()
        {
            PrintCommon(4);
        }

        public void PrintCommon(int left)
        {
            Random r = new Random();
            while (true)
            {
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    Console.SetCursorPosition(left, i);
                    Console.Write(r.Next(0, 10).ToString());
                }
                System.Threading.Thread.Sleep(50);
            }
        }

    }
}
