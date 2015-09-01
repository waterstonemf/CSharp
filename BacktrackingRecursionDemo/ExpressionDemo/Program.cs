using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseExpression exp = new Expression3(10);
            exp.Show();

            Console.ReadLine();

        }
    }
}
