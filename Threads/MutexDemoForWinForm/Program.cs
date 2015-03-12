/*
 * This demo to show Mutex could be used to force only one instance for WinForm app.
 * Note: Application.Exit will not terminate the app if Applicaiton.Run has not been executed.
 * you must return explicitly.
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MutexDemoForWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex m = new Mutex(true, "MutexDemo");
            if(!m.WaitOne(3000)){
                MessageBox.Show("Any Other One is already running");
                System.Windows.Forms.Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            m.ReleaseMutex();
        }
    }
}
