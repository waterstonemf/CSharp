using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if DEBUG
            ConsoleHelper.ShowConsoleWindow();
#endif
            System.Diagnostics.Trace.WriteLine("Form1_load");
#if DEBUG
            Console.Out.WriteLine("This message should be printed on console!");
#endif
        }
    }
}
