using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Realmdigital_Interview.Controllers;
using Realmdigital_Interview.Helpers;

namespace Realmdigital_Interview.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        
        static private ISingleProductResponse singleProductResponse;
        static private IProductListResponse productListResponse;
        ProductController productController = new ProductController(singleProductResponse, productListResponse);
        [TestMethod]
        public void TestGetProductById()
        {
            object result=productController.GetProductById(7);
            Assert.AreEqual(null, result, "Product not found");
        }
        public void TestGetProductByName()
        {
            object result = productController.GetProductsByName("test");
            Assert.AreEqual(null, result, "Product not found");

        }
    }
}
