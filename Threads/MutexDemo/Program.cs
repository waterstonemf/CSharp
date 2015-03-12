/*
 * Though Mutex could be used to implement locking, but it depends on kernel objects so seldom used this way.
 * since Mutex could be use cross processes, so the named Mutex is always used to make sure only one instance running at the same time.
 */ 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MutexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex m = new Mutex(true, "MutexDemo");
            if (!m.WaitOne(3000))
            {
                Console.WriteLine("There is already a Mutext Demo instance running!Only one instance allowed!");
                Console.WriteLine("Press Any Key to Exit...");
                Console.ReadLine();
                System.Environment.Exit(-1);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I am running....");

            Console.ReadLine();
            m.ReleaseMutex();

            
        }
    }
}
