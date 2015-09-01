using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExpressionDemo
{
    class Expression : BaseExpression
    {
        public Expression(int num):base(num){}

        public override void Show()
        {
            sw = new StreamWriter("ExpressionDemo.txt", false, Encoding.UTF8);
            sw.AutoFlush = true;
            List<int> chain = new List<int>();
            IterateExpression(this.Number,chain);
            sw.Close();

            System.Diagnostics.Process.Start("ExpressionDemo.txt");

        }

        public void IterateExpression(int number,List<int> chain)
        {

            for (int i = 1; i <= number / 2; i++)
            {
                int j = number - i;
                this.Count++;
                Print(i, j, chain);
            }


            for (int i = 1; i<= number/2; i++ )
            {
                int j = number - i;
                //if(i>1)
                //{
                //    List<int> chainBefore = new List<int>();
                //    chainBefore.AddRange(chain);
                //    chainBefore.Add(j);
                //    IterateExpression(i, chainBefore);
                //}

                if(j > 1)
                {
                    List<int> chainAfter = new List<int>();
                    chainAfter.AddRange(chain);
                    chainAfter.Add(i);
                    IterateExpression(j, chainAfter);
                }
            }
        }

        public void Print(int num1, int num2 , List<int> chain)
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append(string.Format("#{0} : {1} = {2} + {3}",this.Count,this.Number,num1,num2));
            sb.Append(string.Format("#{0} : {1} = ", this.Count, this.Number));
            foreach(int n in chain)
            {
                sb.Append(string.Format("{0} + ", n));
            }

            sb.Append(string.Format("{0} + {1}",num1,num2));

            Console.WriteLine(sb.ToString());
            sw.WriteLine(sb.ToString());
            sb = null;
        }

    }
}
