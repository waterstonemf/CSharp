using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTower
{
    public class PrintUtil
    {

       public static ConsoleColor ForgoundColor { set { Console.ForegroundColor = value; } }
        
        public static void Print(ConsoleColor color, string content, int left, int top)
        {
            Console.ForegroundColor = color;
            Print(content, left, top);
        }

        public static void Print(string content, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(content);
        }

        public static void Fatal(string msg)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(msg);
            //System.Environment.Exit(-1);
        }
    }
}
