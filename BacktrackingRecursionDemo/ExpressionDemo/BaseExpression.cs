using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExpressionDemo
{
    class BaseExpression
    {
        public int Number { get; set; }
        public int Count { get; set; }
        protected StreamWriter sw = null;


        public BaseExpression(int num)
        {
            this.Number = num;
            this.Count = 0;
        }

        virtual public void Show(){}


    }
}
