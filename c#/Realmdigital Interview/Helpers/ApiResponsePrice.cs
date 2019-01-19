using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Realmdigital_Interview.Helpers
{
    public class ApiResponsePrice
    {
        public string SellingPrice { get; set; }
        public string CurrencyCode { get; set; }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            

            return container;
        }
    }
}