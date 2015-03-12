using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LockKeyWordDemo
{
    class Program
    {
        static int num1 = 1;
        static int num2 = 2;
        static Random r = new Random();
        static int result = 1;
        static object locker = new object();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Calculating5);
            t1.Name = "t1";

            Thread t2 = new Thread(Calculating5);
            t2.Name = "t2";

            t1.Start();
            t2.Start();

            Console.Read();
            
        }

        //divided by 0 exception
        static void Calculating()
        {

            for (int i = 0; i < 10000000; i++ )
            {
                num1 = r.Next(1, 2);
                num2 = r.Next(1, 2);
                result = num1 / num2;
                num2 = 0;
            }
        }

        //divided by 0 exception,too
        static void Calculating2()
        {

            while (true)
            {
                num1 = r.Next(1, 2);
                num2 = r.Next(1, 2);
                result = num1 / num2;
                num2 = 0;
            }
        }

        //no exception
        //maybe Console.Writeline take so much running time, so thread is always paused when they are running COnsole.writeline
        static void Calculating3()
        {

            for (int i = 0; i < 10000000; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                num1 = r.Next(1, 2);
                num2 = r.Next(1, 2);
                result = num1 / num2;
                num2 = 0;
            }
        }

        //no exception just as Calculating3
        //this method is want to emphasize windows is time-slot. even you use while true, each thread will get some time to run
        static void Calculating4()
        {
            while (true)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                num1 = r.Next(1, 2);
                num2 = r.Next(1, 2);
                result = num1 / num2;
                num2 = 0;
            }
        }

        //add lock to avoid race condition
        //lock key word is compiled to Monitor class in IL
        static void Calculating5()
        {
            for (int i = 0; i < 10000000; i++)
            {
                //this object could not be used here
                //keyword 'this' is not valid in a static property, static method, or static field initiator
                lock (locker) 
                {
                    num1 = r.Next(1, 2);
                    num2 = r.Next(1, 2);
                    result = num1 / num2;
                    num2 = 0;
                }
            }
        }
    }
}
