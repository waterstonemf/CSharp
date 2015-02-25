using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WhatHappenedHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                WebServiceHost host = new WebServiceHost(typeof(WhatHappened.CustomerManager));
                
                    host.Open();
                    Console.WriteLine("WCF Service is running...");
                    Console.ReadLine();
                    host.Close();

                    Console.WriteLine("WCF Service has closed");
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
                Console.Read();
            }
        }
    }
}
