using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintCurrentTime);
            t1.Name = "NoDelegateNoParam";

            Thread t2 = new Thread(new ThreadStart(PrintCurrentTime));
            t2.Name = "WithDelegateNoParam";


            Thread t3 = new Thread(PrintCurrentTimeTemperature);
            t3.Name = "NoDelegateWithParam";

            Thread t4 = new Thread(new ParameterizedThreadStart(PrintCurrentTimeTemperature));
            t4.Name = "WithDelegateWithParam";

            t1.Start();
            t2.Start();
            //even define thread as ParameterizedThreadStart, you still have the option to pass no parameter
            //while the parameter will be null in fact
            t3.Start();

            t4.Start(new TemperatureInfo { Temper = 4 });

            Console.Read();

        }


        static void PrintCurrentTime()
        {
            Console.WriteLine(string.Format("Thread Name:{0}, CurrentTime: {1}",Thread.CurrentThread.Name, DateTime.Now.ToString()));
        }

        //Note: the type must be object, int, string ,etc are not allowed.
        //of course, you could convert them as specific type later
        static void PrintCurrentTimeTemperature(object temper)
        {
            TemperatureInfo t = temper as TemperatureInfo;
            if (t == null)
            {
                t = new TemperatureInfo(){Temper=999};
            }
            Console.WriteLine(string.Format("Thread Name:{0}, CurrentTime: {1}, Temperature: {2}°C ", Thread.CurrentThread.Name, DateTime.Now.ToString(), t.Temper.ToString()));
        }
    }

    class TemperatureInfo
    {
        public int Temper { get; set; }
    }
}
