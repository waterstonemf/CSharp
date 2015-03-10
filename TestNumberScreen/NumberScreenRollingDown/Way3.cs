using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace NumberScreenRollingDown
{
    class Way3:IWay
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        const int SWP_NOSIZE = 0x0001;

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

         public void Print()
        {
             IntPtr MyConsole = GetConsoleWindow();
             int xpos = 0;
             int ypos = 0;
             SetWindowPos(MyConsole, 0, xpos, ypos, 0, 0, SWP_NOSIZE);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowWidth = 10;//Console.LargestWindowWidth / 8;
            Console.WindowHeight = Console.LargestWindowHeight;
            
            //Console.WindowTop = -100;
            //Console.WindowLeft = (Console.LargestWindowWidth - Console.WindowWidth) / 2;

            ThreadPool.SetMaxThreads(5, 5);
            Random ranLeft = new Random();
            int left = 0;
             while(true)
             {
                 left = ranLeft.Next(0, Console.WindowWidth);
                 if (left % 3 == 0)
                 {
                     //for (int left = 0 ; left < Console.WindowWidth; left ++)
                     //{
                     ThreadPool.QueueUserWorkItem(new WaitCallback(PrintMethod), new PrintColumn(left));
                     //}

                     Thread.Sleep(30);
                 }
             }

        }

        public void PrintMethod(Object param)
         {
             Random ranLeft = new Random();
             int left = ((PrintColumn)param).Col;

             Random ranValue = new Random();

                 for (int i = 0; i < Console.WindowHeight; i++)
                 {
                     if (i % 2 == 0)
                     {
                         Console.SetCursorPosition(left, i);
                         Console.Write(ranValue.Next(0, 10).ToString());
                     }
                 }
         }
    }


}
