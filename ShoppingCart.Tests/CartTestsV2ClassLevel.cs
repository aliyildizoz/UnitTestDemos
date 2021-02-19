using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTestsV2ClassLevel
    {
        private static CartManager _cartManager;
        private static CartItem _cartItem;
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _cartManager = new CartManagerV2();
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
        [ClassCleanup]
        public static void ClassCleanup()
        {
            _cartManager.Clear();
        }
        [TestMethod]
        public void AddProductToCart()
        {
            //Arange
            var totalItems = _cartManager.TotalItem;
            var totalQuantity = _cartManager.TotalQuantity;

            //Act
            _cartManager.Add(new CartItem
            {
                Product = new Product
                {
                    ProductId = 2,
                    ProductName = "Mouse",
                    UnitPrice = 2500
                },
                Quantity = 1
            });
            //Assert
            Assert.AreEqual(totalItems + 1, _cartManager.TotalItem);
            Assert.AreEqual(totalQuantity + 1, _cartManager.TotalQuantity);
        }

        [TestMethod]
        public void AddCurrentProductToCart()
        {
            //Arange
            var totalItems = _cartManager.TotalItem;
            var totalQuantity = _cartManager.TotalQuantity;

            //Act
            _cartManager.Add(_cartItem);

            //Assert
            Assert.AreEqual(totalItems, _cartManager.TotalItem);
            Assert.AreEqual(totalQuantity + 1, _cartManager.TotalQuantity);
        }
    }
}
