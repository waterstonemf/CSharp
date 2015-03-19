using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingFundInterestCalculator
{
    public partial class Form1 : Form
    {
        private double _totalLoan = 0;
        private double _years = 1;
        private double _yearRate = 0.04;
        private double _monthRate = 0.04 / 12;
        private List<MonthPayInfo> _equalCapitalPayList = new List<MonthPayInfo>();
        private List<MonthPayInfo> _equalCapitalInterestPayList = new List<MonthPayInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ValidateInput();

            //this.dgvEqualCI.Rows.Clear();
            //this.dgvEqualCapital.Rows.Clear();

            this._totalLoan = double.Parse(this.txbTotalLoan.Text) * 10000;
            this._years = double.Parse(this.txbYears.Text);
            this._yearRate = double.Parse(this.txbRate.Text) / 100;
            this._monthRate = this._yearRate / 12;

            CalculateTotalPaid();

            DisplayPayInfo();
        }


        private bool ValidateInput()
        {
            return true;
        }


        private void CalculateTotalPaid()
        {
            CalculateTotalPaidForEqualCI();

            CalculateTotalPaidForEqualCapital();
        }


        private void CalculateTotalPaidForEqualCapital()
        {
            int months = (int)this._years * 12;
            double monthPaidCapital = this._totalLoan / months;
            double loanLeft = this._totalLoan;
            double monthPaidInterest = 0;
            
            for(int i = 1; i<= months; i++)
            {
                monthPaidInterest = loanLeft * this._monthRate;
                this._equalCapitalPayList.Add( new MonthPayInfo(i, monthPaidInterest, monthPaidCapital));
                loanLeft -= monthPaidCapital;      
            }
        }

        private void CalculateTotalPaidForEqualCI()
        {
            int months = (int)this._years * 12;
            //Sn*r*(1+r)^n/((1+r)^n - 1)
            double monthPaidTotal = this._totalLoan * this._monthRate * Math.Pow(1 + this._monthRate, months) / (Math.Pow(1 + this._monthRate, months) - 1);
            double loanLeft = this._totalLoan;
            double monthPaidInterest = 0;
            double monthPaidCapital = 0;
            for (int i = 1; i <= months; i++)
            {
                monthPaidInterest = loanLeft * this._monthRate;
                monthPaidCapital = monthPaidTotal - monthPaidInterest;
                this._equalCapitalInterestPayList.Add(new MonthPayInfo(i, monthPaidInterest, monthPaidCapital));
                loanLeft -= monthPaidCapital;
            }   

        }

        private void DisplayPayInfo()
        {
            DisplayForEqualCI();
            
            DisplayForEqualCapital();
        }

        private void DisplayForEqualCapital()
        {
            double totalPaidInterestForRqualCapital = 0;
            double totalPaidForEqualCapital = 0;

            DataTable dtEqualCapital = new DataTable();
            dtEqualCapital.Clear();
            dtEqualCapital.Columns.Add(new DataColumn() { ColumnName = "Index", Caption = "月份", DataType = typeof(int) });
            dtEqualCapital.Columns.Add(new DataColumn() { ColumnName = "Interest", Caption = "利息", DataType = typeof(double) });
            dtEqualCapital.Columns.Add(new DataColumn() { ColumnName = "Capital", Caption = "本金", DataType = typeof(double) });
            dtEqualCapital.Columns.Add(new DataColumn() { ColumnName = "MonthTotal", Caption = "月还款", DataType = typeof(double) });
            dtEqualCapital.Columns.Add(new DataColumn() { ColumnName = "TotalInterest", Caption = "总利息", DataType = typeof(double) });
            dtEqualCapital.Columns.Add(new DataColumn() { ColumnName = "TotalCapital", Caption = "总本金", DataType = typeof(double) });
            dtEqualCapital.Columns.Add(new DataColumn() { ColumnName = "Total", Caption = "总额", DataType = typeof(double) });

            for (int i = 0; i < this._equalCapitalPayList.Count; i++)
            {
                //DataRow row = dtEqualCapital.NewRow();
                //row["Index"] = i + 1;
                //row["Interest"] = Math.Round(this._equalCapitalPayList[i].PaidInterest, 2);
                //row["Capital"] = Math.Round(this._equalCapitalPayList[i].PaidCapital, 2);
                //row["Total"] = Math.Round(this._equalCapitalPayList[i].PaidTotal, 2);
                //dtEqualCapital.Rows.Add(row);

                //or
                totalPaidInterestForRqualCapital += this._equalCapitalPayList[i].PaidInterest;
                totalPaidForEqualCapital += this._equalCapitalPayList[i].PaidTotal;

                dtEqualCapital.Rows.Add(i + 1, 
                                        Math.Round(this._equalCapitalPayList[i].PaidInterest, 2), 
                                        Math.Round(this._equalCapitalPayList[i].PaidCapital, 2),
                                        Math.Round(this._equalCapitalPayList[i].PaidTotal, 2),
                                        Math.Round(totalPaidInterestForRqualCapital, 2),
                                        Math.Round(totalPaidForEqualCapital - totalPaidInterestForRqualCapital, 2),
                                        Math.Round(totalPaidForEqualCapital, 2));
            }

            this.txbEqualCapitalTotalInterestPaid.Text = Math.Round((totalPaidInterestForRqualCapital / 10000), 2).ToString();
            this.txbEqualCapitalTotalPaid.Text = Math.Round((totalPaidForEqualCapital / 10000), 2).ToString();

            this.dgvEqualCapital.DataSource = dtEqualCapital;
            this.dgvEqualCapital.AutoResizeColumns();
        }

        private void DisplayForEqualCI()
        {
            double totalPaidInterestForEqualCI = 0;
            double totalPaidForEqualCI = 0;

            DataTable dtEqualCapitalInterest = new DataTable();
            dtEqualCapitalInterest.Clear();
            dtEqualCapitalInterest.Columns.Add(new DataColumn() { ColumnName = "Index", Caption = "月份", DataType = typeof(int) });
            dtEqualCapitalInterest.Columns.Add(new DataColumn() { ColumnName = "Interest", Caption = "利息", DataType = typeof(double) });
            dtEqualCapitalInterest.Columns.Add(new DataColumn() { ColumnName = "Capital", Caption = "本金", DataType = typeof(double) });
            dtEqualCapitalInterest.Columns.Add(new DataColumn() { ColumnName = "MonthTotal", Caption = "月还款", DataType = typeof(double) });
            dtEqualCapitalInterest.Columns.Add(new DataColumn() { ColumnName = "TotalInterest", Caption = "总利息", DataType = typeof(double) });
            dtEqualCapitalInterest.Columns.Add(new DataColumn() { ColumnName = "TotalCapital", Caption = "总本金", DataType = typeof(double) });
            dtEqualCapitalInterest.Columns.Add(new DataColumn() { ColumnName = "Total", Caption = "总额", DataType = typeof(double) });

            for (int i = 0; i < this._equalCapitalInterestPayList.Count; i++)
            {
                totalPaidInterestForEqualCI += this._equalCapitalInterestPayList[i].PaidInterest;
                totalPaidForEqualCI += this._equalCapitalInterestPayList[i].PaidTotal;

                DataRow row = dtEqualCapitalInterest.NewRow();
                row["Index"] = i + 1;
                row["Interest"] = Math.Round(this._equalCapitalInterestPayList[i].PaidInterest, 2);
                row["Capital"] = Math.Round(this._equalCapitalInterestPayList[i].PaidCapital, 2);
                row["MonthTotal"] = Math.Round(this._equalCapitalInterestPayList[i].PaidTotal, 2);
                row["TotalInterest"] = Math.Round(totalPaidInterestForEqualCI, 2);
                row["TotalCapital"] = Math.Round(totalPaidForEqualCI - totalPaidInterestForEqualCI, 2);
                row["Total"] = Math.Round(totalPaidForEqualCI, 2);

                dtEqualCapitalInterest.Rows.Add(row);
            }

            this.txbEqualCITotalInterestPaid.Text = Math.Round((totalPaidInterestForEqualCI / 10000), 2).ToString();
            this.txbEqualCITotalPaid.Text = Math.Round((totalPaidForEqualCI / 10000), 2).ToString();

            this.dgvEqualCI.DataSource = dtEqualCapitalInterest;
            this.dgvEqualCI.AutoResizeColumns();
        }


        
    }
}
