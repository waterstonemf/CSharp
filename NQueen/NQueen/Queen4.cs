using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    class Queen4
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
                bool flag = false;
                for (int c = 0; c < QUEEN; c++)
                {
                    if (IsValid(r, c))
                    {
                        flag = true;
                        a[r] = c;
                        Place(r + 1);
                    }else
                    {
                        //一定要有这个分之，否则一行在某一列如果找到过设置为了true，后面列就全true了，而有可能后面再没有true了。所以每一次找都要重设标志位
                        flag = false;
                    }
                }

                //前面的都是用结果来判断当前行是否找到了合适的位置，a[r] == INITIAL , 这里不用结果，而用一个查找中设置的一个变量来判断。不过似乎没有直接用结果来的方便。
                //if ((!flag)&& r > 0)
                //{
                //    a[r - 1] = INITIAL;
                //}

                //原先想的是用flag来判断是否找到。就像上面的写法。但是。存在一个问题，如第4行的第7个位置找到了，然后递归到第5行，一个没找到，又回到了第4行第7位置，然后for循环结束
                //但这时flag为true，所以本来应该清掉第三行的占位的，结果没请。 所以这里不判断找没找到，只要这一行结束了，理论上上一行要换个位置继续找了，所以都把它的占位清了。
                //为什么Queen3的算法不存在这个问题，因为Queen3中，第4行的占位在第5行没有找到的时候自动给清了，然后用a[r] == INITAL判断时总会是true，相当于本处不加flag的情况。
                if (r > 0)
                {
                    a[r - 1] = INITIAL;
                }
            }
        }
    }
}
