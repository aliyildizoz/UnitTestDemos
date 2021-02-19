using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTestsV2TestLevel
    {
        private CartManager _cartManager;
        private CartItem _cartItem;
        [TestInitialize]
        public void TestInitialize()
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            _cartManager.Clear();
        }
        [TestMethod]
        public void AddProductToCart()
        {
            const int excepted = 1;
            var totalItems = _cartManager.TotalItem;

            Assert.AreEqual(excepted, totalItems);
        }

        [TestMethod]
        public void RemoveCurrentProductToCart()
        {
            int excepted = _cartManager.TotalItem - 1;

            _cartManager.Remove(_cartItem.Product.ProductId);
            var totalItems = _cartManager.TotalItem;

            Assert.AreEqual(excepted, totalItems);
        }

        [TestMethod]
        public void ClearCart()
        {
            _cartManager.Clear();

            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItem);
        }
    }
}
