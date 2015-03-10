using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace NumberScreenRollingDown
{
    class Way5 : Way4
    {
        public override void Print()
        {
            ConsoleHelper.SetConsoleIcon(SystemIcons.Error);
            ConsoleHelper.PrintAllSupportedConsoleFonts();
            ConsoleHelper.SetConsoleFont(9);
            
             base.Print();

        }



    }
}
