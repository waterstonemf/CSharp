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

namespace BackgroundWorkerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker1.CancellationPending)
            {
                UpdateProgressBar();
                System.Threading.Thread.Sleep(100); // 这里如果设置成10ms，会看到进度条永远到达不了最右端，也就是一般的样子。
                //因为UI线程来不及刷新。而且，间隔时间太短的话，在UpdateProgressBar时总会出现Form 已经被Disposed的异常。间隔时间调大些异常就没有了
            }
        }

        private void UpdateProgressBar()
        {
            if (this!= null && this.InvokeRequired && !this.IsDisposed)
            {
                try
                {
                    this.Invoke(new MethodInvoker(UpdateProgressBar));
                }catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else
            {

                if (this.progressBar1.Value == this.progressBar1.Maximum)
                {
                    this.progressBar1.Value = this.progressBar1.Minimum;
                }
                this.progressBar1.Value += 1;
                //if (this.progressBar1.Value < this.progressBar1.Maximum)
                //{
                //    this.progressBar1.Value += 1;
                //}
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.backgroundWorker1.IsBusy)
                {
                    this.backgroundWorker1.CancelAsync();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                this.progressBar1.Value = this.progressBar1.Minimum;
            }
            this.progressBar1.Value += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.timer1.Enabled)
            {
                this.timer1.Stop();
                this.button1.Text = "StartTimer";
            }
            else
            {
                this.timer1.Start();
                this.button1.Text = "StopTimer";
            }
        }
    }
}
