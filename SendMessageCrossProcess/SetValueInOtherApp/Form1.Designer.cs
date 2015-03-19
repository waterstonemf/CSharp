namespace SetValueInCPPApp
{
    partial class FormSetValueInCPP
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
            this.txbValue = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCaption = new System.Windows.Forms.TextBox();
            this.rtbControls = new System.Windows.Forms.RichTextBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnRaiseClick = new System.Windows.Forms.Button();
            this.btnSetInCSharp = new System.Windows.Forms.Button();
            this.btnRaiseBtnClickInCSharp = new System.Windows.Forms.Button();
            this.gbCPP = new System.Windows.Forms.GroupBox();
            this.gbCSharp = new System.Windows.Forms.GroupBox();
            this.gbCPP.SuspendLayout();
            this.gbCSharp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(190, 495);
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(183, 20);
            this.txbValue.TabIndex = 0;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(46, 19);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caption";
            // 
            // txbCaption
            // 
            this.txbCaption.Location = new System.Drawing.Point(150, 31);
            this.txbCaption.Name = "txbCaption";
            this.txbCaption.Size = new System.Drawing.Size(211, 20);
            this.txbCaption.TabIndex = 0;
            this.txbCaption.Text = "HandleInDialog";
            // 
            // rtbControls
            // 
            this.rtbControls.Location = new System.Drawing.Point(34, 85);
            this.rtbControls.Name = "rtbControls";
            this.rtbControls.Size = new System.Drawing.Size(445, 386);
            this.rtbControls.TabIndex = 3;
            this.rtbControls.Text = "";
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(391, 31);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 4;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnRaiseClick
            // 
            this.btnRaiseClick.Location = new System.Drawing.Point(31, 59);
            this.btnRaiseClick.Name = "btnRaiseClick";
            this.btnRaiseClick.Size = new System.Drawing.Size(108, 23);
            this.btnRaiseClick.TabIndex = 5;
            this.btnRaiseClick.Text = "RaiseBtnCLick";
            this.btnRaiseClick.UseVisualStyleBackColor = true;
            this.btnRaiseClick.Click += new System.EventHandler(this.btnRaiseClick_Click);
            // 
            // btnSetInCSharp
            // 
            this.btnSetInCSharp.Location = new System.Drawing.Point(55, 19);
            this.btnSetInCSharp.Name = "btnSetInCSharp";
            this.btnSetInCSharp.Size = new System.Drawing.Size(75, 23);
            this.btnSetInCSharp.TabIndex = 1;
            this.btnSetInCSharp.Text = "SetInCSharp";
            this.btnSetInCSharp.UseVisualStyleBackColor = true;
            this.btnSetInCSharp.Click += new System.EventHandler(this.btnSetInCSharp_Click);
            // 
            // btnRaiseBtnClickInCSharp
            // 
            this.btnRaiseBtnClickInCSharp.Location = new System.Drawing.Point(30, 59);
            this.btnRaiseBtnClickInCSharp.Name = "btnRaiseBtnClickInCSharp";
            this.btnRaiseBtnClickInCSharp.Size = new System.Drawing.Size(146, 23);
            this.btnRaiseBtnClickInCSharp.TabIndex = 5;
            this.btnRaiseBtnClickInCSharp.Text = "RaiseBtnCLickInCSharp";
            this.btnRaiseBtnClickInCSharp.UseVisualStyleBackColor = true;
            this.btnRaiseBtnClickInCSharp.Click += new System.EventHandler(this.btnRaiseBtnClickInCSharp_Click);
            // 
            // gbCPP
            // 
            this.gbCPP.Controls.Add(this.btnSet);
            this.gbCPP.Controls.Add(this.btnRaiseClick);
            this.gbCPP.Location = new System.Drawing.Point(58, 548);
            this.gbCPP.Name = "gbCPP";
            this.gbCPP.Size = new System.Drawing.Size(200, 100);
            this.gbCPP.TabIndex = 6;
            this.gbCPP.TabStop = false;
            this.gbCPP.Text = "C++";
            // 
            // gbCSharp
            // 
            this.gbCSharp.Controls.Add(this.btnSetInCSharp);
            this.gbCSharp.Controls.Add(this.btnRaiseBtnClickInCSharp);
            this.gbCSharp.Location = new System.Drawing.Point(290, 548);
            this.gbCSharp.Name = "gbCSharp";
            this.gbCSharp.Size = new System.Drawing.Size(200, 100);
            this.gbCSharp.TabIndex = 7;
            this.gbCSharp.TabStop = false;
            this.gbCSharp.Text = "C#";
            // 
            // FormSetValueInCPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 687);
            this.Controls.Add(this.gbCSharp);
            this.Controls.Add(this.gbCPP);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.rtbControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCaption);
            this.Controls.Add(this.txbValue);
            this.Name = "FormSetValueInCPP";
            this.Text = "SetValueInOtherCPP";
            this.gbCPP.ResumeLayout(false);
            this.gbCSharp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCaption;
        private System.Windows.Forms.RichTextBox rtbControls;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnRaiseClick;
        private System.Windows.Forms.Button btnSetInCSharp;
        private System.Windows.Forms.Button btnRaiseBtnClickInCSharp;
        private System.Windows.Forms.GroupBox gbCPP;
        private System.Windows.Forms.GroupBox gbCSharp;
    }
}

