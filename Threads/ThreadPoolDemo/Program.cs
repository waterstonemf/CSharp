using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolDemo
{
    class Work
    {
        public int Index {get;set;}
        public void Do(object obj)
        {
            int available = 0;
            int complete = 0;
            ThreadPool.GetAvailableThreads(out available, out complete);
            Console.WriteLine(string.Format("#{0} thread does #{1} work. {2} available.", Thread.CurrentThread.ManagedThreadId, Index, available));
            Thread.Sleep(100);
        }

        public void DoByOne(object obj)
        {
            int available = 0;
            int complete = 0;
            ThreadPool.GetAvailableThreads(out available, out complete);
            Console.WriteLine(string.Format("#{0} thread does #{1} work. {2} available.", Thread.CurrentThread.ManagedThreadId, Index, available));
        }

    }
    class Program
    {
        static int taskNum = 1;
        static object _locker = new object();

        static void Main(string[] args)
        {
            //ThreadPool pool = new ThreadPool();
            ThreadPool.SetMaxThreads(5,5);

            while(taskNum < 30)
            {
                ThreadPool.QueueUserWorkItem((new Work() { Index = taskNum }).Do);
                taskNum++;
            }

            Thread.Sleep(5000);
            Console.WriteLine("Done!Press Any key to continue next demo");
            Console.ReadLine();
            Console.Clear();

            //if set only one thread in the pool, it's not necessary always the same thread.
            //the thead id changed. just make sure only one thread in the pool at any time.
            ThreadPool.SetMaxThreads(1, 1);
            taskNum = 1;
            while (taskNum < 100)
            {
                ThreadPool.QueueUserWorkItem((new Work() { Index = taskNum }).DoByOne);
                taskNum++;
            }

            Console.ReadLine();  
        }
    }
}
