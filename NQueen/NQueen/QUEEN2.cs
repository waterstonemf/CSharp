using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    class Queen2
    {
        const int QUEEN = 8;   //queen count
        const int INITIAL = -1000;
        int _answerCount = 0;

        int[] a = new int[QUEEN];

        void Init()
        {
            for (int i = 0; i < QUEEN; i++)
            {
                a[i] = INITIAL;
            }
        }

        bool IsValid(int row, int col)
        {
            for (int r = 0; r < row; r++)
            {
                if ((a[r] == col) || (Math.Abs(r - row) == Math.Abs(a[r] - col)))
                {
                    return false;
                }
            }

            return true;
        }

        void Print()
        {
            this._answerCount++;

            StringBuilder answer = new StringBuilder(string.Format("{0:d2}", this._answerCount));
            answer.Append(":");
            for (int r = 0; r < QUEEN; r++)
            {
                answer.AppendFormat("{0} ", a[r]);
            }

            Console.WriteLine(answer.ToString());
        }


        public void Test()
        {
            Init();
            int r = 0;
            Place(r);
        }


        public void Place(int r)
        {
            if(r == QUEEN)
            {
                Print();
                a[r-1] = INITIAL;
            }else
            {
                for(int c = 0 ; c<QUEEN;c++)
                {
                    if(IsValid(r,c))
                    {
                        a[r] = c;
                        Place(r + 1);
                    }
                }
            }
        }

    }
}
