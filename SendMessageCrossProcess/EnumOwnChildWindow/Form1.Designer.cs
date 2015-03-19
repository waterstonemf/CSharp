namespace EnumOwnChildWindow
{
    partial class Form1
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
            this.txbNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txbNumber2 = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.rtbChildList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbNumber1
            // 
            this.txbNumber1.Location = new System.Drawing.Point(108, 68);
            this.txbNumber1.Name = "txbNumber1";
            this.txbNumber1.Size = new System.Drawing.Size(100, 20);
            this.txbNumber1.TabIndex = 0;
            this.txbNumber1.Text = "11";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(22, 68);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(50, 13);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Number1";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(22, 116);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(50, 13);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "Number2";
            // 
            // txbNumber2
            // 
            this.txbNumber2.Location = new System.Drawing.Point(108, 116);
            this.txbNumber2.Name = "txbNumber2";
            this.txbNumber2.Size = new System.Drawing.Size(100, 20);
            this.txbNumber2.TabIndex = 0;
            this.txbNumber2.Text = "7";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(264, 106);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(22, 161);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(108, 154);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(100, 20);
            this.txbResult.TabIndex = 0;
            this.txbResult.Text = "0";
            // 
            // rtbChildList
            // 
            this.rtbChildList.Location = new System.Drawing.Point(25, 212);
            this.rtbChildList.Name = "rtbChildList";
            this.rtbChildList.Size = new System.Drawing.Size(486, 304);
            this.rtbChildList.TabIndex = 3;
            this.rtbChildList.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 548);
            

            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.txbNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.txbNumber2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.rtbChildList);
            this.Controls.Add(this.btnSum);      
            
            this.Name = "Form1";
            this.Text = "FormInCSharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumber1;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txbNumber2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.RichTextBox rtbChildList;
    }
}

