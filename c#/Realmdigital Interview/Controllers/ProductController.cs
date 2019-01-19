using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using Realmdigital_Interview.Helpers;
using Microsoft.Practices.Unity;

namespace Realmdigital_Interview.Controllers
{
    [Route("products")]
    public class ProductController : Base
    {
        private ISingleProductResponse singleProductResponse;
        private IProductListResponse productListResponse;
        public ProductController(ISingleProductResponse singleProductDecoder, IProductListResponse productListDecoder)
        {
            singleProductResponse=singleProductDecoder;
            productListResponse=productListDecoder;
        }

        [Route("product")]
        public object GetProductById(int productId)
        {
            //SingleProductDecoder response = new SingleProductDecoder();
            return singleProductResponse.decodeResponse((List<ApiResponseProduct>)Base.getResponse(productId));                        
        }
       

        [Route("product/search")]
        public List<object> GetProductsByName(string productName)
        {
            //ProductListDecoder response = new ProductListDecoder();
            return productListResponse.decodeResponse((List<ApiResponseProduct>)Base.getResponse(productName));            
        }
    }
     
}