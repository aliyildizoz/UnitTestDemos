using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartManagerV2 : CartManager
    {
        public override void Add(CartItem cartItem)
        {
            var res = CartItems.FirstOrDefault(item => item.Product.ProductId == cartItem.Product.ProductId);
            if (res == null)
            {
                base.Add(cartItem);
                return;
            }

            res.Quantity += cartItem.Quantity;
        }
    }
}
