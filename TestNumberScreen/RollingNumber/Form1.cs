using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RollingNumber
{
    public partial class Form1 : Form
    {
        private const int EMPLOYEE_NUM = 356;
        private Random _ran = new Random();
        private int _num = 0;

        Thread t = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (t == null || t.ThreadState == ThreadState.Running || t.ThreadState == ThreadState.Aborted)
            {
                return;
            }

            if (t.ThreadState == ThreadState.Suspended)
            {
                t.Resume();
            }
            else
            {
                t.Start();
            }
        }

        private void GenerateRandomNumber()
        {
            while(true)
            {
                this._num = this._ran.Next(1, EMPLOYEE_NUM);
                if (!this.InvokeRequired)
                {
                    DisplayRandomeNumber();
                }else
                {
                    this.Invoke(new MethodInvoker(DisplayRandomeNumber));
                }

                this._num = this._ran.Next(1, EMPLOYEE_NUM);
                Thread.Sleep(100);
            }
        }

        private void DisplayRandomeNumber()
        {
            this.label1.Text = this._num.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            t.Suspend();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(GenerateRandomNumber);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null && !((t.ThreadState & ThreadState.Aborted) == ThreadState.Aborted || (t.ThreadState & ThreadState.AbortRequested) == ThreadState.AbortRequested))
            {
                t.Abort();
            }


            System.Windows.Forms.Application.ExitThread();
            System.Windows.Forms.Application.Exit();

        }

    }
}
