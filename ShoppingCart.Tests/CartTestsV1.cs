using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTestsV1
    {
        [TestMethod]
        public void AddProductToCart()
        {
            //Arrange
            const int excepted = 1;

            var cartManager = new CartManager();
            var cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };

            //Act
            cartManager.Add(cartItem);
            var totalItems = cartManager.TotalItem;

            Assert.AreEqual(excepted, totalItems);
        }

        [TestMethod]
        public void RemoveCurrentProductToCart()
        {
            var cartManager = new CartManager();
            var cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
            cartManager.Add(cartItem);

            //Arrange
            int excepted = cartManager.TotalItem - 1;

            //Act
            cartManager.Remove(cartItem.Product.ProductId);
            var totalItems = cartManager.TotalItem;

            Assert.AreEqual(excepted, totalItems);
        }

        [TestMethod]
        public void ClearCart()
        {
            //Arrange
            var cartManager = new CartManager();
            var cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
            cartManager.Add(cartItem);

            //Act
            cartManager.Clear();

            Assert.AreEqual(0, cartManager.TotalQuantity);
            Assert.AreEqual(0, cartManager.TotalItem);
        }
    }
}
