using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

namespace WhatHappened
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CustomerManager : ICustomerManager
    {
        public CustomerInfo GetCustomerProfiler(string cardNumber)
        {
            CustomerInfo ci = null;
            if (!string.IsNullOrEmpty(cardNumber))
            {
                if (cardNumber.Equals("VIP12345"))
                {
                    ci = new CustomerInfo("VIP12345", "Jason Thomas", 30, 'M');
                }
                else if (cardNumber.Equals("VIP66666"))
                {
                    ci = new CustomerInfo("VIP66666", "Jason Burdon", 35, 'M');
                }
            }

            return ci;
        }

        public List<CustomerInfo> GetCustomers(string name)
        {
            List<CustomerInfo> ciList = new List<CustomerInfo>();

            if (!string.IsNullOrEmpty(name) && name.Equals("Jason"))
            {
                ciList.Add(new CustomerInfo("VIP12345", "Jason Thomas", 30, 'M'));
                ciList.Add(new CustomerInfo("VIP66666", "Jason Burdon", 35, 'M'));
            }

            return ciList;

        }

        public bool IsExisted(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber))
            {
                return false;
            }

            if (cardNumber.Equals("VIP12345") || cardNumber.Equals("VIP66666"))
            {
                return true;
            }

            return false;
        }

       // [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "AddCustomer")]
        public bool AddCustomer(CustomerInfo customer)
        {
            return true;
        }

        public bool CustomerMerge(CustomerInfo survivor, CustomerInfo victim)
        {
            Console.WriteLine(string.Format("Survivor:{0},Victim:{1}",survivor.ToString(),victim.ToString()));

            return true;
        }

        public string TestServerResponse()
        {
            WebOperationContext.Current.OutgoingRequest.Headers.Add("Access-Control-Allow-Origin", "*"); 
            return "Response from server : " + DateTime.Now.ToString();
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public UserInfo Login(string loginName, string password)
        {
            if (loginName == "IGTSYSTEMS" && password == "123456")
            {
                return new UserInfo("1", "IGTSYSTEMS", "Supervisor", 13, 'F');
            }

            return null;
        }

        public List<CreditInfo> GetCreditDetail(string loginName)
        {
            List<CreditInfo> ciList = new List<CreditInfo>();

            ciList.Add(new CreditInfo(DateTime.Now, 100));
            ciList.Add(new CreditInfo(DateTime.Now.Subtract(new TimeSpan(24,0,0)), 300));

            return ciList;
        }

    }
}
