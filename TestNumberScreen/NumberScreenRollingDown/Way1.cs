using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberScreenRollingDown
{
    class Way1 : IWay
    {
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random r = new Random();

            while (true)
            {
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    for (int i = 0; i < Console.WindowHeight; i++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(r.Next(1, 9).ToString());
                    }
                    System.Threading.Thread.Sleep(100);
                }
            }      
        }
    }
}
