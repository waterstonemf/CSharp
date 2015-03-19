using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFundInterestCalculator
{
    struct MonthPayInfo
    {
        public int MonthIndex;
        public double PaidInterest;
        public double PaidCapital;
        public double PaidTotal;

        public MonthPayInfo(int index, double interest, double capital)
        {
            this.MonthIndex = index;
            this.PaidInterest = interest;
            this.PaidCapital = capital;
            this.PaidTotal = this.PaidInterest + this.PaidCapital;
        }

    }

    
}
