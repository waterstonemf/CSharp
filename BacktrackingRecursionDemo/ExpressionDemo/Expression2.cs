using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExpressionDemo
{
    class Expression2:BaseExpression
    {
        private int[] NUMBERS = new int[100];
        public Expression2(int num) : base(num) {
            
            //init NUMBERS
            for (int i = 0; i< NUMBERS.Length; i++)
            {
                NUMBERS[i] = i + 1;
            }
        }


        public override void Show()
        {
            sw = new StreamWriter("ExpressionDemo.txt", false, Encoding.UTF8);
            sw.AutoFlush = true;

            System.Diagnostics.Process.Start("ExpressionDemo.txt");
        }

        public void IterateExpression()
        {
            //for(int numCount = 2 ; numCount <= this.Number; numCount++)
            //{
            //    while(numCount > 0)
            //    {

            //    }
            //}
        }
    }
}
