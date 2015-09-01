using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExpressionDemo
{
    class Expression3:BaseExpression
    {
        private List<List<int>> _chains = new List<List<int>>();
        private List<string> _strChains = new List<string>();
        
        public Expression3(int num):base(num){}


        public override void Show()
        {

            List<int> chain = new List<int>();
            IterateExpression(this.Number,chain);

            foreach(List<int> c in _chains)
            {
                c.Sort();
            }

            foreach(List<int> c in _chains)
            {
                StringBuilder sb = new StringBuilder();
                foreach(int n in c)
                {
                    sb.Append(n.ToString() + " + ");
                }

                sb.Remove(sb.Length - 3, 3); // remove last " + ";
                _strChains.Add(sb.ToString());
            }


            _strChains.Sort();

            sw = new StreamWriter("ExpressionDemo.txt", false, Encoding.UTF8);
            sw.AutoFlush = true;

            string pre = string.Empty;

            for (int i = 0; i < _strChains.Count; i++ )
            {
                
                if(_strChains[i] != pre)
                {
                    Console.WriteLine(_strChains[i]);
                    sw.WriteLine(_strChains[i]);
                    pre = _strChains[i];
                }
            }

            sw.Close();

                System.Diagnostics.Process.Start("ExpressionDemo.txt");

        }

        public void IterateExpression(int number,List<int> chain)
        {

            for (int i = 1; i <= number / 2; i++)
            {
                int j = number - i;
                this.Count++;
                Save(i, j, chain);
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

        public void Save(int num1, int num2 , List<int> chain)
        {

            List<int> newChain = new List<int>();
            newChain.AddRange(chain);
            newChain.Add(num1);
            newChain.Add(num2);

            _chains.Add(newChain);

            //StringBuilder sb = new StringBuilder();
            ////sb.Append(string.Format("#{0} : {1} = {2} + {3}",this.Count,this.Number,num1,num2));
            //sb.Append(string.Format("#{0} : {1} = ", this.Count, this.Number));
            //foreach(int n in chain)
            //{
            //    sb.Append(string.Format("{0} + ", n));
            //}

            //sb.Append(string.Format("{0} + {1}",num1,num2));

            //Console.WriteLine(sb.ToString());
            //sw.WriteLine(sb.ToString());
            //sb = null;
        }
    }
}
