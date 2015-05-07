namespace LearningChinese
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panControl = new System.Windows.Forms.Panel();
            this.rtbWord = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panControl
            // 
            this.panControl.BackColor = System.Drawing.Color.LightBlue;
            this.panControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panControl.Location = new System.Drawing.Point(0, 634);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(1097, 50);
            this.panControl.TabIndex = 1;
            this.panControl.Visible = false;
            // 
            // rtbWord
            // 
            this.rtbWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbWord.Font = new System.Drawing.Font("SimSun", 150F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbWord.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rtbWord.Location = new System.Drawing.Point(0, 0);
            this.rtbWord.Name = "rtbWord";
            this.rtbWord.Size = new System.Drawing.Size(1097, 634);
            this.rtbWord.TabIndex = 2;
            this.rtbWord.Text = "";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 684);
            this.Controls.Add(this.rtbWord);
            this.Controls.Add(this.panControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panControl;
        private System.Windows.Forms.RichTextBox rtbWord;
    }
}

