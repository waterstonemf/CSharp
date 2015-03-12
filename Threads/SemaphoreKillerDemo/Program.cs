using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SemaphoreKillerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the killer of semaphore since I will occupy semaphore for ever without releasing....");
            Semaphore sem = new Semaphore(10, 10, "SemaphoreDemo");
            int occupied = 0;
            while (occupied < 10)
            {
                sem.WaitOne();
                occupied++;
                Console.WriteLine("Got One! Total " + occupied.ToString() + " Occupied!");
            }

            Console.ReadLine();
            
        }
    }
}
