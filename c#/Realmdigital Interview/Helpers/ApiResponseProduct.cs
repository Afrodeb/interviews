using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Realmdigital_Interview.Helpers
{
    public class ApiResponseProduct
    {
        public string BarCode { get; set; }
        public string ItemName { get; set; }
        public List<ApiResponsePrice> PriceRecords { get; set; }
    }
}