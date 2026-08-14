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
        public int GetTotalItemCount()
        {
            int count = 0;

            foreach (CartItem item in cartItems)
            {
                count += item.Quantity;
            }

            return count;
        }
        public void Remove(int id)
        {
            CartItem item = cartItems.FirstOrDefault(x => x.Id == id);

            if (item != null)
            {
                cartItems.Remove(item);
            }
        }
    }
}
