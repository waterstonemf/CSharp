namespace HousingFundInterestCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbPaidWay = new System.Windows.Forms.GroupBox();
            this.rbEqualCapital = new System.Windows.Forms.RadioButton();
            this.rbEqualCI = new System.Windows.Forms.RadioButton();
            this.txbRate = new System.Windows.Forms.TextBox();
            this.txbYears = new System.Windows.Forms.TextBox();
            this.txbTotalLoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbEqualCITotalPaid = new System.Windows.Forms.TextBox();
            this.txbEqualCITotalInterestPaid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbEqualCapitalTotalPaid = new System.Windows.Forms.TextBox();
            this.txbEqualCapitalTotalInterestPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvEqualCI = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvEqualCapital = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbPaidWay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqualCI)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqualCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.gbPaidWay);
            this.groupBox1.Controls.Add(this.txbRate);
            this.groupBox1.Controls.Add(this.txbYears);
            this.groupBox1.Controls.Add(this.txbTotalLoan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(67, 191);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(169, 33);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbPaidWay
            // 
            this.gbPaidWay.Controls.Add(this.rbEqualCapital);
            this.gbPaidWay.Controls.Add(this.rbEqualCI);
            this.gbPaidWay.Location = new System.Drawing.Point(19, 134);
            this.gbPaidWay.Name = "gbPaidWay";
            this.gbPaidWay.Size = new System.Drawing.Size(256, 47);
            this.gbPaidWay.TabIndex = 4;
            this.gbPaidWay.TabStop = false;
            this.gbPaidWay.Text = "还款方式";
            // 
            // rbEqualCapital
            // 
            this.rbEqualCapital.AutoSize = true;
            this.rbEqualCapital.Location = new System.Drawing.Point(123, 20);
            this.rbEqualCapital.Name = "rbEqualCapital";
            this.rbEqualCapital.Size = new System.Drawing.Size(73, 17);
            this.rbEqualCapital.TabIndex = 4;
            this.rbEqualCapital.Text = "等额本金";
            this.rbEqualCapital.UseVisualStyleBackColor = true;
            // 
            // rbEqualCI
            // 
            this.rbEqualCI.AutoSize = true;
            this.rbEqualCI.Checked = true;
            this.rbEqualCI.Location = new System.Drawing.Point(17, 19);
            this.rbEqualCI.Name = "rbEqualCI";
            this.rbEqualCI.Size = new System.Drawing.Size(73, 17);
            this.rbEqualCI.TabIndex = 4;
            this.rbEqualCI.TabStop = true;
            this.rbEqualCI.Text = "等额本息";
            this.rbEqualCI.UseVisualStyleBackColor = true;
            // 
            // txbRate
            // 
            this.txbRate.Location = new System.Drawing.Point(94, 98);
            this.txbRate.Name = "txbRate";
            this.txbRate.Size = new System.Drawing.Size(74, 20);
            this.txbRate.TabIndex = 3;
            this.txbRate.Text = "4";
            // 
            // txbYears
            // 
            this.txbYears.Location = new System.Drawing.Point(94, 62);
            this.txbYears.Name = "txbYears";
            this.txbYears.Size = new System.Drawing.Size(74, 20);
            this.txbYears.TabIndex = 2;
            this.txbYears.Text = "30";
            // 
            // txbTotalLoan
            // 
            this.txbTotalLoan.Location = new System.Drawing.Point(94, 29);
            this.txbTotalLoan.Name = "txbTotalLoan";
            this.txbTotalLoan.Size = new System.Drawing.Size(74, 20);
            this.txbTotalLoan.TabIndex = 1;
            this.txbTotalLoan.Text = "120";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "基准年利率:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "贷款年限:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "万元";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "总贷款额:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbEqualCITotalPaid);
            this.groupBox2.Controls.Add(this.txbEqualCITotalInterestPaid);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(366, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "等额本息";
            // 
            // txbEqualCITotalPaid
            // 
            this.txbEqualCITotalPaid.Enabled = false;
            this.txbEqualCITotalPaid.Location = new System.Drawing.Point(84, 62);
            this.txbEqualCITotalPaid.Name = "txbEqualCITotalPaid";
            this.txbEqualCITotalPaid.Size = new System.Drawing.Size(113, 20);
            this.txbEqualCITotalPaid.TabIndex = 6;
            this.txbEqualCITotalPaid.Text = "0";
            // 
            // txbEqualCITotalInterestPaid
            // 
            this.txbEqualCITotalInterestPaid.Enabled = false;
            this.txbEqualCITotalInterestPaid.Location = new System.Drawing.Point(84, 29);
            this.txbEqualCITotalInterestPaid.Name = "txbEqualCITotalInterestPaid";
            this.txbEqualCITotalInterestPaid.Size = new System.Drawing.Size(113, 20);
            this.txbEqualCITotalInterestPaid.TabIndex = 7;
            this.txbEqualCITotalInterestPaid.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "本息总和:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "总利息：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbEqualCapitalTotalPaid);
            this.groupBox3.Controls.Add(this.txbEqualCapitalTotalInterestPaid);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(366, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "等额本金";
            // 
            // txbEqualCapitalTotalPaid
            // 
            this.txbEqualCapitalTotalPaid.Enabled = false;
            this.txbEqualCapitalTotalPaid.Location = new System.Drawing.Point(84, 62);
            this.txbEqualCapitalTotalPaid.Name = "txbEqualCapitalTotalPaid";
            this.txbEqualCapitalTotalPaid.Size = new System.Drawing.Size(113, 20);
            this.txbEqualCapitalTotalPaid.TabIndex = 6;
            this.txbEqualCapitalTotalPaid.Text = "0";
            // 
            // txbEqualCapitalTotalInterestPaid
            // 
            this.txbEqualCapitalTotalInterestPaid.Enabled = false;
            this.txbEqualCapitalTotalInterestPaid.Location = new System.Drawing.Point(84, 29);
            this.txbEqualCapitalTotalInterestPaid.Name = "txbEqualCapitalTotalInterestPaid";
            this.txbEqualCapitalTotalInterestPaid.Size = new System.Drawing.Size(113, 20);
            this.txbEqualCapitalTotalInterestPaid.TabIndex = 7;
            this.txbEqualCapitalTotalInterestPaid.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "本息总和:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "总利息：";
            // 
            // dgvEqualCI
            // 
            this.dgvEqualCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEqualCI.Location = new System.Drawing.Point(6, 19);
            this.dgvEqualCI.Name = "dgvEqualCI";
            this.dgvEqualCI.Size = new System.Drawing.Size(582, 315);
            this.dgvEqualCI.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvEqualCI);
            this.groupBox4.Location = new System.Drawing.Point(10, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(719, 340);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "等额本息";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvEqualCapital);
            this.groupBox5.Location = new System.Drawing.Point(10, 632);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(719, 340);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "等额本金";
            // 
            // dgvEqualCapital
            // 
            this.dgvEqualCapital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEqualCapital.Location = new System.Drawing.Point(6, 19);
            this.dgvEqualCapital.Name = "dgvEqualCapital";
            this.dgvEqualCapital.Size = new System.Drawing.Size(582, 315);
            this.dgvEqualCapital.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "万元";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "万元";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(196, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "万元";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "万元";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(196, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "万元";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 982);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "住房公积金计算器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPaidWay.ResumeLayout(false);
            this.gbPaidWay.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqualCI)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEqualCapital)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbPaidWay;
        private System.Windows.Forms.RadioButton rbEqualCapital;
        private System.Windows.Forms.RadioButton rbEqualCI;
        private System.Windows.Forms.TextBox txbRate;
        private System.Windows.Forms.TextBox txbYears;
        private System.Windows.Forms.TextBox txbTotalLoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbEqualCITotalPaid;
        private System.Windows.Forms.TextBox txbEqualCITotalInterestPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbEqualCapitalTotalPaid;
        private System.Windows.Forms.TextBox txbEqualCapitalTotalInterestPaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvEqualCI;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvEqualCapital;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

