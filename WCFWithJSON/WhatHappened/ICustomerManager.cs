using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WhatHappened
{
    [ServiceContract]
    
    public interface ICustomerManager
    {

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCustomerProfiler", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        CustomerInfo GetCustomerProfiler(string cardNumber);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCustomers", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        List<CustomerInfo> GetCustomers(string name);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "IsExisted/{cardNumber}")]
        bool IsExisted(string cardNumber);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddCustomer", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        bool AddCustomer(CustomerInfo customer);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "CustomerMerge", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        bool CustomerMerge(CustomerInfo survivor, CustomerInfo victim);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,UriTemplate = "TestServerResponse")]
        string TestServerResponse();

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Add",BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        int Add(int x, int y);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Login", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        UserInfo Login(string loginName,string password);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCreditDetail", BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        List<CreditInfo> GetCreditDetail(string loginName);
    }
}
