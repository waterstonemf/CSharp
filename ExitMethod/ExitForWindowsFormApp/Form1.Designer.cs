namespace ExitForWindowsFormApp
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
            this.btnExitByApplication = new System.Windows.Forms.Button();
            this.btnExitByEnvironment = new System.Windows.Forms.Button();
            this.btnExitByChecking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitByApplication
            // 
            this.btnExitByApplication.Location = new System.Drawing.Point(31, 38);
            this.btnExitByApplication.Name = "btnExitByApplication";
            this.btnExitByApplication.Size = new System.Drawing.Size(182, 23);
            this.btnExitByApplication.TabIndex = 0;
            this.btnExitByApplication.Text = "ExitByApplication";
            this.btnExitByApplication.UseVisualStyleBackColor = true;
            this.btnExitByApplication.Click += new System.EventHandler(this.btnExitByApplication_Click);
            // 
            // btnExitByEnvironment
            // 
            this.btnExitByEnvironment.Location = new System.Drawing.Point(31, 79);
            this.btnExitByEnvironment.Name = "btnExitByEnvironment";
            this.btnExitByEnvironment.Size = new System.Drawing.Size(182, 23);
            this.btnExitByEnvironment.TabIndex = 1;
            this.btnExitByEnvironment.Text = "ExitByEnvironment";
            this.btnExitByEnvironment.UseVisualStyleBackColor = true;
            this.btnExitByEnvironment.Click += new System.EventHandler(this.btnExitByEnvironment_Click);
            // 
            // btnExitByChecking
            // 
            this.btnExitByChecking.Location = new System.Drawing.Point(31, 123);
            this.btnExitByChecking.Name = "btnExitByChecking";
            this.btnExitByChecking.Size = new System.Drawing.Size(182, 23);
            this.btnExitByChecking.TabIndex = 2;
            this.btnExitByChecking.Text = "ExitByChecking";
            this.btnExitByChecking.UseVisualStyleBackColor = true;
            this.btnExitByChecking.Click += new System.EventHandler(this.btnExitByChecking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExitByChecking);
            this.Controls.Add(this.btnExitByEnvironment);
            this.Controls.Add(this.btnExitByApplication);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitByApplication;
        private System.Windows.Forms.Button btnExitByEnvironment;
        private System.Windows.Forms.Button btnExitByChecking;
    }
}

