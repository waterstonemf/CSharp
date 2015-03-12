/*
 * Though Monitor also have other methods, like Wait, Pulse, PulseAll,
 * 但是这些方法必须在你取得完lock之后才行，而且涉及多次的解锁和加锁的过程，很多人不建议使用。
 * 如果想用这种方式，可以使用AutoResetEvent 或者 ManualResetEvent
 * 下面这篇文章详细的解释了这几个方法该怎么用
 * http://www.codeproject.com/Articles/28785/Thread-synchronization-Wait-and-Pulse-demystified
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MonitorDemo
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
            Thread t1 = new Thread(Calculating2);
            t1.Name = "t1";

            Thread t2 = new Thread(Calculating2);
            t2.Name = "t2";

            t1.Start();
            t2.Start();

            Console.Read();
        }

        //Enter is a blocking method
        static void Calculating()
        {

            for (int i = 0; i < 10000000; i++)
            {
                Console.WriteLine(string.Format("{0} Before Enter...",Thread.CurrentThread.Name));
                Monitor.Enter(locker);
                Console.WriteLine(string.Format("{0} Entered..., Press Any Key to continue",Thread.CurrentThread.Name));
                Console.Read();
                try
                {
                    num1 = r.Next(1, 2);
                    num2 = r.Next(1, 2);
                    result = num1 / num2;
                    num2 = 0;
                }
                finally
                {
                    Console.WriteLine(string.Format("{0} Exit...", Thread.CurrentThread.Name));
                    Monitor.Exit(locker);   
                }
            }
        }

        /// <summary>
        /// using TryEnter to avoid blocking for ever
        /// </summary>
        static void Calculating2()
        {

            for (int i = 0; i < 10000000; i++)
            {
                Console.WriteLine(string.Format("{0} Before Enter...", Thread.CurrentThread.Name));
                if(!Monitor.TryEnter(locker, 5000))
                {
                    Console.WriteLine(string.Format("{0}: I wait for 5 seconds and then I give up....", Thread.CurrentThread.Name));
                    continue;
                }
                Console.WriteLine(string.Format("{0} Entered...,Press any key to continue or wait to see other theads giveup", Thread.CurrentThread.Name));
                Console.Read();
                try
                {
                    num1 = r.Next(1, 2);
                    num2 = r.Next(1, 2);
                    result = num1 / num2;
                    num2 = 0;
                }
                finally
                {
                    Console.WriteLine(string.Format("{0} Exit...", Thread.CurrentThread.Name));
                    Monitor.Exit(locker);
                }
            }
        }

        
    }
}
