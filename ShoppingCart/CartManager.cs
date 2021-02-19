using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartManager
    {
        private readonly List<CartItem> _cartItems;

        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }

        public virtual void Add(CartItem cartItem)
        {
            _cartItems.Add(cartItem);
        }
        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(item => item.Product.ProductId == productId);
            _cartItems.Remove(product);
        }
        public void Clear()
        {
            _cartItems.Clear();
        }
        public List<CartItem> CartItems => _cartItems;
        public decimal TotalPrice => _cartItems.Sum(item => item.Quantity * item.Product.UnitPrice);
        public int TotalQuantity => _cartItems.Sum(item => item.Quantity);
        public int TotalItem => _cartItems.Count;

    }
}
