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
    public partial class HintFrm : Form
    {
        public HintFrm()
        {
            InitializeComponent();
        }

        private void HintFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public Image HintImage
        {
            get { return this.pictureBox1.Image; }
            set { this.pictureBox1.Image = value;
            }
        }
    }
}
