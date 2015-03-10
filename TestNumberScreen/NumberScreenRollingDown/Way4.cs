using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NumberScreenRollingDown
{
    class Way4:IWay
    {
        public virtual void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowHeight = Console.LargestWindowHeight;
            Random ranLeft = new Random();
            int top = 0;

            while (true)
            {
                for (int left = 0; left < Console.WindowWidth; left++)
                {
                    if (left % 3 == 0)
                    {
                        ThreadPool.QueueUserWorkItem(PrintMethod, new PrintInfo(left, top, ranLeft.Next(0, 9)));
                    }
                }
                    top++;
                Thread.Sleep(100);
            }
            
        }

        public void PrintMethod(Object param)
        {
            PrintInfo pi  =  param as PrintInfo;
            //Console.SetCursorPosition(pi.Left, pi.Top);
            Console.CursorLeft = pi.Left;
            ////Console.CursorTop = pi.Top;
            //Console.Write(pi.Content.ToString());

            if (pi.Left >= Console.WindowWidth - 3)
            {
                Console.WriteLine(pi.Content.ToString());
            }
            else
            {

                Console.Write(pi.Content.ToString());
            }
            //if(pi.Col == 6)
            //{
            //    Console.WriteLine();
            //}

            //Random ranLeft = new Random();
            //int left = ((PrintColumn)param).Col;

            //Random ranValue = new Random();

            //for (int i = 0; i < Console.WindowHeight; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.SetCursorPosition(left, i);
            //        Console.Write(ranValue.Next(0, 10).ToString());
            //    }
            //}
        }

    }
}
