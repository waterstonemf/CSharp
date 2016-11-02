using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestByteRead
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("in.txt"))
            {
                sw.Write("abcdefghijklmnopqrstuvwxyz");
            }

            FileStream fs = new FileStream("in.txt", FileMode.Open);
            byte[] data = new byte[4];
            int readCount = 0;
            int result = fs.Read(data, 0, 4);
            readCount++;
            while (result > 0 )
            {
                Console.WriteLine("{0} Times Read with below data: ", readCount);

                int j = 0;
                do
                {
                    if (data[j] > 0) { Console.Write((char)data[j]); }
                    else { break; }

                    j++;

                } while (j < data.Length);
                Console.WriteLine("\r\n");

                //clear the data
                for(int i = 0; i < data.Length; i++) { data[i] = 0; }

                result = fs.Read(data, 0, 4);
                readCount++;
                if (result <= 0)
                {
                    Console.WriteLine("{0} Times Read with below data: ", readCount);
                    Console.WriteLine("Meet the end of file with read result {0}",result);   
                }
            }

            Console.Read();
        }
    }
}
