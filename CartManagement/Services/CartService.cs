using CartManagement.Models;
using CartManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CartManagement.Services
{
    public class CartService
    {
        private CartRepository cartRepository;

        public CartService(CartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }
        public void AddItem(CartItem item)
        {
            cartRepository.Add(item);
        }
        public decimal CalculateTotal()
        {
            List<CartItem> items = cartRepository.GetAll();

            decimal total = 0;

            foreach (CartItem item in items)
            {
                total += item.Quantity * item.UnitPrice;
            }

            return total;
        }
    }
}
