/*
 * This demo shows the usage for AutoResetEvent and ManualResetEvent.
 * What does Reset mean?
 * both AutoResetEvent and ManualResetEvent have a Reset Method and commented as :
 * Sets the state of the event to nonsignaled, causing threads to block.
 * 
 * Reset 自该是恢复的意思。信号亮一下，然后就灭了。不Reset的意思就是，信号亮了就常亮着，不灭。
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AutoManualResetEventDemo
{
    class Program
    {
        static AutoResetEvent auto = new AutoResetEvent(false);
        static ManualResetEvent manual = new ManualResetEvent(false);
        static object _locker = new object();

        static void Main(string[] args)
        {

            WaiterSay("Dinner is not ready, Please be patient...");

            new Thread(WaitingForAutoResetEvent) { Name="Zhang San"}.Start();
            new Thread(WaitingForAutoResetEvent) { Name = "Li Si"}.Start();
            new Thread(WaitingForAutoResetEvent) { Name = "Wang Ma Zi" }.Start();

            //need to call multiple Set() for multiple WaitOne()
            Thread.Sleep(1000 * 3);
            WaiterSay("Dinner is ready!");
            auto.Set();
            

            Thread.Sleep(1000 * 5);
            WaiterSay("Dinner is ready!");
            auto.Set();
            

            Thread.Sleep(1000 * 3);
            WaiterSay("Dinner is ready!");
            auto.Set();

            Console.WriteLine("Press any key to see the scenario for ManualResetEvent \n");
            Console.ReadLine();
            Console.Clear();

            WaiterSay("Dinner is not ready, Please be patient...");

            new Thread(WaitingForManualResetEvent) { Name = "Zhang San" }.Start();
            new Thread(WaitingForManualResetEvent) { Name = "Li Si" }.Start();
            new Thread(WaitingForManualResetEvent) { Name = "Wang Ma Zi" }.Start();

            //only one Set() needed for multiple WaitOne()
            Thread.Sleep(1000 * 3);
            WaiterSay("Dinner is ready!");
            manual.Set();

            Console.ReadLine();

        }


        static void WaitingForAutoResetEvent()
        {
            CustomerSay(string.Format("{0}: Pls call me when it's ready....", Thread.CurrentThread.Name));
            if(!auto.WaitOne(1000*10))
            {
                DiedForStarving(string.Format("{0} died for starving", Thread.CurrentThread.Name));
                return;
            }

            CustomerSay(string.Format("{0}: Many thanks!", Thread.CurrentThread.Name)); 
        }

        static void WaitingForManualResetEvent()
        {
            CustomerSay(string.Format("{0}: Pls call me when it's ready....", Thread.CurrentThread.Name));
            if (!manual.WaitOne(1000 * 10))
            {
                DiedForStarving(string.Format("{0} died for starving", Thread.CurrentThread.Name));
                return;
            }

            CustomerSay(string.Format("{0}: Many thanks!", Thread.CurrentThread.Name));
        }


        static void WaiterSay(string msg)
        {
            lock (_locker)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(string.Format("Waiter: {0}\n", msg));
            }
        }

        static void CustomerSay(string msg)
        {
            lock (_locker)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Format("{0}\n", msg));
            }
        }

        static void DiedForStarving(string msg)
        {
            lock (_locker)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("{0}\n", msg));
            }
        }
    }
}
