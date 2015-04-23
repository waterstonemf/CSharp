using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    class Queen
    {
        const int QUEEN = 8;   //queen count
        const int INITIAL = -1000;
        int _answerCount = 0;

        int[] a = new int[QUEEN];

        void Init()
        {
            for(int i = 0; i<QUEEN; i++)
            {
                a[i] = INITIAL;
            }
        }

        bool IsValid(int row, int col)
        {
            for(int r = 0; r < QUEEN ; r++)
            {
                if((a[r] == col) || (Math.Abs(r - row) == Math.Abs(a[r] - col)))
                {
                    return false;
                }
            }

            return true;
        }


        void Print()
        {
            this._answerCount++;

            StringBuilder answer = new StringBuilder(string.Format("{0:d2}",this._answerCount));
            answer.Append(":");
            for(int r = 0 ; r < QUEEN; r++)
            {
                answer.AppendFormat("{0} ", a[r]);
            }

            Console.WriteLine(answer.ToString());
        }

        void PlaceQueen()
        {
            int r = 0, c = 0;
            while (r < QUEEN)
            {

                //这个地方也可以考虑使用for循环，
                /*
                 *  for(c = 0; c< N; c++)
                 *  {
                 *  }
                 *  
                 *  但是，考虑到回溯时，失败后需要从记忆中的下一步开始，所以，至少直观上不能是老从c= 0 开始，而至少应该在循环外围声明一个start 值，让c= start; c< N; C++
                 *  但还有一个问题，start只是解决了一个起始值的问题，c的值会逐渐增的，有时候需要从0开始的，所以这样的话不仅需要一个start变量，还需要随时更改c本身的值
                 *  所以c也不能声明在for内作为局部变量，而必须声明在外部
                 *  这样的话， 就不如 用while (c< QUEEN) 来的直接和自然了
                 */


                while (c < QUEEN)        //对r行的每一列进行探测，看是否可以放置皇后
                {
                    if (IsValid(r, c))      //该位置可以放置皇后
                    {
                        a[r] = c;        //第r行放置皇后
                        c = 0;           //第r行放置皇后以后，需要继续探测下一行的皇后位置，所以此处将c清零，从下一行的第0列开始逐列探测，因为下一行可能直接条状到第56行
                        break;
                    }
                    else
                    {
                        ++c;             //继续探测下一列
                    }
                }

                if (a[r] == INITIAL)         //第r行没有找到可以放置皇后的位置
                {
                    if (r == 0)             //回溯到第一行，仍然无法找到可以放置皇后的位置，则说明已经找到所有的解，程序终止
                        break;
                    else                    //没有找到可以放置皇后的列，此时就应该回溯
                    {
                        --r;
                        c = a[r] + 1;        //把上一行皇后的位置往后移一列,直接跳转到第58行
                        a[r] = INITIAL;      //把上一行皇后的位置清除，重新探测
                        continue;            //直接把程序跳转到第56行
                    }
                }

                if (r == QUEEN - 1)          //最后一行找到了一个皇后位置，说明找到一个结果，打印出来
                {
                    Print();
                    //不能在此处结束程序，因为我们要找的是N皇后问题的所有解，此时应该清除该行的皇后，从当前放置皇后列数的下一列继续探测。
                    //_sleep(600);
                    c = a[r] + 1;             //从最后一行放置皇后列数的下一列继续探测
                    a[r] = INITIAL;           //清除最后一行的皇后位置
                    continue;                 //直接把程序跳转到第56行
                }

                ++r;              //继续探测下一行的皇后位置
            }
        }


        public void Test()
        {
            Init();
            PlaceQueen();
        }

    }
}
