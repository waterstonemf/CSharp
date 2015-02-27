using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExitForConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input app or env to use Application.Exit() or Environment.Exit()");
            string cmd = Console.ReadLine();
            if (cmd.ToLower() == "app")
            {
                // works correctly
                System.Windows.Forms.Application.Exit();
            }else if (cmd.ToLower() == "env")
            {
                //works correctly
                System.Environment.Exit(-1);
            }
        }
    }
}
