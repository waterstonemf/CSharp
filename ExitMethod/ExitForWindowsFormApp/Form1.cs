using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExitForWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// works correctly with no problem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitByApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// works correctly with no problem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitByEnvironment_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }


        /// <summary>
        /// works correctly with no problem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitByChecking_Click(object sender, EventArgs e)
        {
            if(System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }else
            {
                System.Environment.Exit(-1);
            }
        }
    }
}
