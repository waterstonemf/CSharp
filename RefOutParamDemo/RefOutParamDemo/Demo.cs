using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutParamDemo
{
    class Demo
    {
        public void Do()
        {
            Class1  cls  = null;
            AssignClass(cls);

            if (cls != null)
            {
                Console.WriteLine(cls.Msg);
            }
            else
            {
                Console.WriteLine("NULL Reference");
            }

            AssignClassByRef(ref cls);

            if (cls != null)
            {
                Console.WriteLine(cls.Msg);
            }
            else
            {
                Console.WriteLine("NULL Reference");
            }


            int[] arr = null;

            AssignArrayByRef(ref arr);

            if (arr != null)
            {
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("null arr by ref");
            }

            arr = null;
            AssignArrayByOut(out arr);

            if (arr != null)
            {
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("null arr by ref");
            }
        }

        public void AssignClass(Class1 cls)
        {
            cls = new Class1 { Msg = "Demo for Ref and out" };
        }

        public void AssignClassByRef(ref Class1 cls)
        {
            cls = new Class1 { Msg = "Demo for Ref and out" };
        }

        public void AssignArrayByRef(ref int[] arr)
        {
            if (arr == null)
            {
                arr = new int[10];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 100 + i;
            }
        }

        public void AssignArrayByOut(out int[] arr)
        {
            arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 100 + i;
            }
        }
    }
}
