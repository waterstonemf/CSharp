using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i= 100; i<=999 ; i++)
            {
                for(int j = 100; j<=i; j++)
                {
                    int result = i - j;
                    if (result < 100 && result >= 10)
                    {
                        string str_i = i.ToString();
                        char[] arr_i = str_i.ToArray();

                        string str_j = j.ToString();
                        char[] arr_j = str_j.ToArray();

                        string str_r = result.ToString();
                        char[] arr_r = str_r.ToArray();

                        if ((arr_i[0] == arr_j[2]) && (arr_i[0] == arr_r[0]) && (arr_i[1] == arr_j[0]) && (arr_i[1] == arr_r[1]) && (arr_i[2] == arr_j[1]))
                        {
                            Console.WriteLine("{0} - {1} = {2}", i, j, result);
                        }
                    }
                }
            }

            Console.Read();
        }
    }
}
