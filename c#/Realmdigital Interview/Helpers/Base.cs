using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Realmdigital_Interview.Helpers
{
    public abstract class Base 
    {
        protected static string response = "";
        static int value;
        protected static List<object> result;
        public Base() {
            result = new List<object>();
        }
        protected static object getResponse(object variable)
        {
            if (int.TryParse(variable.ToString(), out value))
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    response = client.UploadString(WebApiApplication.baseUrl, "POST", "{ \"id\": \"" + variable + "\" }");
                }
                return JsonConvert.DeserializeObject<List<ApiResponseProduct>>(response);
            }
            else {
                using (WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    response = client.UploadString(WebApiApplication.baseUrl, "POST", "{ \"names\": \"" + variable + "\" }");
                }
                return JsonConvert.DeserializeObject<List<ApiResponseProduct>>(response);
            }
        }

       


    }
}