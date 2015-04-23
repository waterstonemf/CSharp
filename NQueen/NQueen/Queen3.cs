using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    class Queen3
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
            //判断的时候判断所有行的
            for (int r = 0; r < QUEEN; r++)
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
            if (r == QUEEN)
            {
                Print();
                a[r - 1] = INITIAL;
            }
            else
            {
                for (int c = 0; c < QUEEN; c++)
                {
                    if (IsValid(r, c))
                    {
                        a[r] = c;
                        Place(r + 1);
                    }
                }

                //no proper position for row r, we need to reset the postion for a[r-1].
                //因为到第r行的时候，第r-1行肯定已经占了一个位置。当第r行没有合适的位置，返回到第r-1行的下一列继续执行时，加入r-1行业没有合适的位置，就会继续回溯到r-2行，
                //但这时r-1行又标明自己占用了一个位置，而我们IsValid判断的时候，又是判断的所有行的，所以这时就有问题，所以当第r行没有可用位置的时候，一定要替r-1行把占用的位置清掉
                //此外，必须把r>0 加上，因为第一行没有r-1

                //如果不想加这个貌似手动回溯的步骤，就参照Queen2的IsValid的方法，只判断前r行的，这样即使后面有些脏数据也不怕了
                if(a[r] == INITIAL && r > 0)
                {
                    a[r - 1] = INITIAL;
                }
            }
        }
    }
}
