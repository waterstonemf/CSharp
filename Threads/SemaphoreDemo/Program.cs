/*
 * This demo shows the usage of semaphore.
 * semaphore allows some threads to run at the same time insteading only allowing one thread.
 * semaphore is used when you have a few resouces, like charis, so only some of people could use at the same time and others must wait until someone releasing one resouce.
 * if you run 2 instance, you could see the semaphore could be used cross process
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SemaphoreDemo
{
    class Program
    {
        static Semaphore sem = new Semaphore(10, 10,"SemaphoreDemo");
        static int count = 0;
        static object _locker = new object();

        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                Thread t = new Thread(Start);
                t.Name = string.Format("T{0}",i);
                t.Start();
            }

            Console.ReadLine();
        }

        static void Start()
        {
            Console.WriteLine(string.Format("{0}:I am trying to get a semaphore...", Thread.CurrentThread.Name));
            if(!sem.WaitOne(1000*60*1))
            {
                Console.WriteLine(string.Format("{0}: I wait for 1 minute and then I give up....", Thread.CurrentThread.Name));
                return;
            }

            try
            {
                lock(_locker)
                {
                    count++;
                    Console.WriteLine(string.Format("Currently total {0} threads are running and I am {1}",count,Thread.CurrentThread.Name));
                }
                Thread.Sleep(2000);
            }finally
            {
                
                lock (_locker)
                {
                    sem.Release();
                    count--;
                    Console.WriteLine(string.Format("I am {0} and Now I Exit, total {1} threads are running now", Thread.CurrentThread.Name,count));
                    
                }
            }
            
        }
    }
}
