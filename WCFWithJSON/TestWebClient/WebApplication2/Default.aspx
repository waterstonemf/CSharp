<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title></title>
         <script language="javascript" type="text/javascript">
             function TestServerResponse(contentType) {
                 // Create HTTP request
                 var xmlHttp = CreateHttpRequest();
                 if (xmlHttp == null) {
                     return;
                 }
 
                 var url = "http://10.222.116.74:8731/WhatHappened/CustomerManager/TestServerResponse";
                 //发送Http请求
                 xmlHttp.open("GET", url, true);
                 xmlHttp.send()
         }


         function IsExisted(contentType) {
             var cardNumber = document.getElementById("cardNumber").value;

             if (cardNumber) {
                 // Create HTTP request
                 var xmlHttp = CreateHttpRequest();
                 if (xmlHttp == null) {
                     return;
                 }

                 var url = "http://10.222.116.74:8731/WhatHappened/CustomerManager/IsExisted";
                 url = url + "/" + cardNumber;

                 xmlHttp.open("GET", url, true);
                 xmlHttp.send()
             } else {
             alert("Pls Input Parameters");
             }
         }

         function Add(contentType) {
             var x = document.getElementById("valuex").value;
             var y = document.getElementById("valuey").value;

             if (x && y) {
                 // Create HTTP request
                 var xmlHttp = CreateHttpRequest();
                 if (xmlHttp == null) {
                     return;
                 }

                 var url = "http://10.222.116.74:8731/WhatHappened/CustomerManager/Add";

                 xmlHttp.open("POST", url, true);
                 xmlHttp.setRequestHeader("Content-type", "application/json");
                 var body = '{"x":';
                 body = body + x + ',"y":' + y +'}';
                 xmlHttp.send(body);
             } else {
                 alert("Pls Input Parameters");
             }
         }

         function GetCustomerProfiler(contentType) {
             var cardNumberProfiler = document.getElementById("cardNumberProfiler").value;

             if (cardNumberProfiler) {
                 // Create HTTP request
                 var xmlHttp = CreateHttpRequest();
                 if (xmlHttp == null) {
                     return;
                 }

                 var url = "http://127.0.0.1:8731/WhatHappened/CustomerManager/GetCustomerProfiler";

                 xmlHttp.open("POST", url, true);
                 xmlHttp.setRequestHeader("Content-type", "application/json");
                 var body = '{"cardNumber":"';
                 body = body + cardNumberProfiler + '"}';
                 xmlHttp.send(body);
             } else {
                 alert("Pls Input Parameters");
             }
         }

         function GetCustomers(contentType) {
             var name = document.getElementById("name").value;

             if (name) {
                 // Create HTTP request
                 var xmlHttp = CreateHttpRequest();
                 if (xmlHttp == null) {
                     return;
                 }

                 var url = "http://10.222.116.74:8731/WhatHappened/CustomerManager/GetCustomers";

                 xmlHttp.open("POST", url, true);
                 xmlHttp.setRequestHeader("Content-type", "application/json");
                 var body = '{"name":"';
                 body = body + name + '"}';
                 xmlHttp.send(body);
             } else {
                 alert("Pls Input Parameters");
             }
         }

         function AddCustomer(contentType) {
             var addCardNumber = document.getElementById("addCardNumber").value;
             var addName = document.getElementById("addName").value;
             var addAge = document.getElementById("addAge").value;
             var addSex = document.getElementById("addSex").value;

             if (addCardNumber && addName && addAge && addSex) {
                 // Create HTTP request
                 var xmlHttp = CreateHttpRequest();
                 if (xmlHttp == null) {
                     return;
                 }

                 var url = "http://10.222.116.74:8731/WhatHappened/CustomerManager/AddCustomer";

                 xmlHttp.open("POST", url, true);
                 xmlHttp.setRequestHeader("Content-type", "application/json");
                 var body = '{"customer":{"Name":"' + addName + '","CardNumber":"' + addCardNumber + '","Age":' + addAge + ',"Sex":"' + addSex +'"}}';
                 xmlHttp.send(body);
             } else {
                 alert("Pls Input Parameters");
             }
         }

         function CustomerMerge(contentType) {
             var addCardNumber = document.getElementById("Text1").value;
             var addName = document.getElementById("Text2").value;
             var addAge = document.getElementById("Text3").value;
             var addSex = document.getElementById("Text4").value;

             var addCardNumber2 = document.getElementById("Text5").value;
             var addName2 = document.getElementById("Text6").value;
             var addAge2 = document.getElementById("Text7").value;
             var addSex2 = document.getElementById("Text8").value;

             if (addCardNumber && addName && addAge && addSex) {
                 // Create HTTP request
                 var xmlHttp = CreateHttpRequest();
                 if (xmlHttp == null) {
                     return;
                 }

                 var url = "http://10.222.116.74:8731/WhatHappened/CustomerManager/CustomerMerge";

                 xmlHttp.open("POST", url, true);
                 xmlHttp.setRequestHeader("Content-type", "application/json");
                 var body = '{"survivor":{"Name":"' + addName + '","CardNumber":"' + addCardNumber + '","Age":' + addAge + ',"Sex":"' + addSex + '"},';
                 body = body + '"victim":{"Name":"' + addName2 + '","CardNumber":"' + addCardNumber2 + '","Age":' + addAge2 + ',"Sex":"' + addSex2 + '"}}';
                 xmlHttp.send(body);
             } else {
                 alert("Pls Input Parameters");
             }
         }

         function TestPost(contentType) {
             var name = document.getElementById("name").value;

             if (name) {
                 // Create HTTP request
                 var xmlHttp = CreateHttpRequest();
                 


                 //初始化操作Url
                 //tools.self.com:站点发布的域名
                 //ajaxEndpoint请参阅web.config中配置
                 //<endpoint address="ajaxEndpoint" behaviorConfiguration="jsonWcfBehavior"
                 //  binding="customBinding"
                 //  bindingConfiguration="JsonMapper" contract="IJsonWCFService">
                 //</endpoint>
                 //GetJsonResult:服务方法名称
                 var url = "http://10.222.116.74:8731/WhatHappened/CustomerManager/TestServerResponse";

                 //初始化Json消息
                 var body = '{"name":"';
                 body = body + name + '"}';
                 //发送Http请求
                 xmlHttp.open("POST", url, true);
                 xmlHttp.setRequestHeader("Content-type", contentType);
                 xmlHttp.send(body);
             }
         }
         
         //创建HttpRequest对象
         function CreateHttpRequest() {
             var httpRequest;
             try {
                 httpRequest = new XMLHttpRequest();
             }
             catch (e) {
                 try {
                     httpRequest = new ActiveXObject("Msxml2.XMLHTTP");
                 }
                 catch (e) {
                     try {
                         httpRequest = new ActiveXObject("Microsoft.XMLHTTP");
                     }
                     catch (e) {
                         return null;
                     }
                 }
             }

             if (httpRequest == null) {
                 alert("此实例只能在支持Ajax的浏览器中运行");
             } else {
                // Create result handler
                httpRequest.onreadystatechange = function() {
                if (httpRequest.readyState == 4) {
                    //var result = eval("(" + httpRequest.responseText + " )").GetJsonResultResult;
                       //result = result + "<br/>";
                    var result = httpRequest.responseText;
                     document.getElementById("divMessagePanel").innerHTML = result;
                 }
             }
             }
             
             return httpRequest;
         }        
         
     </script>
</head>
<body>
    
     <h1>
         JsonContentTypeMapper 客户端页面</h1>
         <div style="font-size: 16px; color: red" id="divMessagePanel"></div>
     <p><input type="button" onclick="return TestServerResponse('text/javascript');" value="TestServerResponse" /></p>

     <hr />
     
    <p>
         CardNumber:<input type="text" id="cardNumber" /> VIP12345 OR VIP66666 </br>
         <input type="button" onclick="return IsExisted('text/javascript');" value="IsExisted" /></p>
    <hr />
    
    <p>
         X: <input type="text" id="valuex" /> + Y: <input type="text" id="valuey" />   </br>
         <input type="button" onclick="return Add('text/javascript');" value="Add" /></p>
   <hr />
    <p>
         CardNumber:<input type="text" id="cardNumberProfiler" /> VIP12345 OR VIP66666 </br>
         <input type="button" onclick="return GetCustomerProfiler('text/javascript');" value="GetCustomerProfiler" /></p>
   <hr />
     
         <p>
         Name:<input type="text" id="name" /> Jason </br>
         <input type="button" onclick="return GetCustomers('text/javascript');" value="GetCustomers" /></p>
   <hr />
   
            <p>Add Customer </br>
         CardNumber:<input type="text" id="addCardNumber" /> </br>
         Name:<input type="text" id="addName" /> </br>
          Age:<input type="text" id="addAge" /> </br>
          Sex:<input type="text" id="addSex" /> </br>
         <input type="button" onclick="return AddCustomer('text/javascript');" value="AddCustomer" /></p>
   <hr />
   
               <p>Customer  Merge</br>
         Survivor:</br>
         CardNumber:<input type="text" id="Text1" /> </br>
         Name:<input type="text" id="Text2" /> </br>
          Age:<input type="text" id="Text3" /> </br>
          Sex:<input type="text" id="Text4" /> </br>
          
         Victim:</br>
         CardNumber:<input type="text" id="Text5" /> </br>
         Name:<input type="text" id="Text6" /> </br>
          Age:<input type="text" id="Text7" /> </br>
          Sex:<input type="text" id="Text8" /> </br>
          

         <input type="button" onclick="return CustomerMerge('text/javascript');" value="CustomerMerge" /></p>
   <hr />
     
     
</body>
</html>
