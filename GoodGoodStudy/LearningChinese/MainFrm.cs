using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LearningChinese
{
    public partial class MainFrm : Form
    {
        Dictionary _d = null;
        LoadModelType _loadModel = LoadModelType.Nomal;
        List<string> _currentList = new List<string>();

        public MainFrm()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("你确定要结束程序？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                AdjustFontSize(true);
            }
            else if (e.KeyCode == Keys.Up)
            {
                AdjustFontSize(false);
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                e.SuppressKeyPress = true;
                ShowHint();
            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
                e.SuppressKeyPress = true;
                ShowAbout();
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                e.SuppressKeyPress = true;
                ShowNextWord();
            }
            else if (e.KeyCode == Keys.PageUp)
            {
                e.SuppressKeyPress = true;
                ShowPreviousWord();
            }


        }


        private void AdjustFontSize(bool smaller)
        {
            float currentSize = this.rtbWord.Font.Size;

            if (smaller)
            {
                if (currentSize <= 10)
                {
                    MessageBox.Show(string.Format("当前字体大小为{0},已到最小值", currentSize));
                    return;
                }

                currentSize -= 10;
            }
            else
            {
                if (currentSize >= 180)
                {
                    MessageBox.Show(string.Format("当前字体大小为{0},已到最大值", currentSize));
                    return;
                }

                currentSize += 10;
            }

            this.rtbWord.Font = new Font(this.rtbWord.Font.FontFamily, currentSize);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //this.rtbWord.Text = "好";

            //Dictionary di = new Dictionary();
            //di.ImgPath = "img";
            //di.LoadModel = LoadModelType.Nomal;
            //di.NormalList = new List<string>() { "天", "地", "日", "月" };
            //di.NewList = new List<string>() { "出入平安", "好", "你", "山" };

            //try
            //{
            //    ConfigUtil.SaveDictionay(di);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            try
            {
                Dictionary d = ConfigUtil.LoadDictionay();
                if (d == null)
                {
                    MessageBox.Show("没有加载到字典信息");
                    Application.Exit();
                }

                this._d = d;
                this._loadModel = d.LoadModel;
                if (this._loadModel == LoadModelType.Nomal)
                {
                    this._currentList = d.NormalList;
                }
                else if (this._loadModel == LoadModelType.New)
                {
                    this._currentList = d.NewList;
                }

                if (this._currentList == null || this._currentList.Count == 0)
                {
                    MessageBox.Show("字典中没有发现可用的字或语句");
                    return;
                }

                HintUtil.ImgPath = d.ImgPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载字典的时候出错\r\n" + ex.ToString());
                Application.Exit();
            }

            ShowNextWord();
        }

        private void ShowHint()
        {
            HintFrm hint = new HintFrm();
            hint.HintImage = HintUtil.LoadImage(this.rtbWord.Text);

            hint.Left = this.Left + (this.Width - hint.Width) / 2;
            hint.Top = this.Top + this.Height - hint.Height - 50;
            hint.ShowDialog();
        }

        private void ShowAbout()
        {
            AboutFrm about = new AboutFrm();

            about.Left = this.Left + (this.Width - about.Width) / 2;
            about.Top = this.Top + this.Height - about.Height - 50;
            about.ShowDialog();
        }

        private void ShowNextWord()
        {
            if(this._currentList.Count == 1)
            {
                this.rtbWord.Text = this._currentList.ElementAt(0);
                return;
            }

            Random r = new Random();
             int index = -1;
             do
             {
                 index = r.Next(this._currentList.Count);
             } while (index == HistoryUtil.Last);

             HistoryUtil.Add(index);

             this.rtbWord.Text = this._currentList.ElementAt(index);
        }


        private void ShowPreviousWord()
        {
            if(HistoryUtil.Count > 1)
            {
                this.rtbWord.Text = this._currentList.ElementAt(HistoryUtil.Previous);
            }
        }
    }
}
