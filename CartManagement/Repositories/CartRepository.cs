using CartManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CartManagement.Repositories
{
    public class CartRepository
    {
        private List<CartItem> cartItems = new List<CartItem>();
        public void Add(CartItem item)
        {
            cartItems.Add(item);
        }
        public List<CartItem> GetAll()
        {
            return cartItems;
        }
    }
}
