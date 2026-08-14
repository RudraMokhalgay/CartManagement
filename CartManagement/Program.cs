using CartManagement.Models;
using CartManagement.Repositories;
using CartManagement.Services;

namespace CartManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Repository
            CartRepository cartRepository = new CartRepository();

            // Give Repository to Service
            CartService cartService = new CartService(cartRepository);

            // Create 3 CartItems
            CartItem item1 = new CartItem
            {
                Id = 1,
                ProductName = "Laptop",
                Quantity = 2,
                UnitPrice = 50000
            };

            CartItem item2 = new CartItem
            {
                Id = 2,
                ProductName = "Mouse",
                Quantity = 3,
                UnitPrice = 500
            };

            CartItem item3 = new CartItem
            {
                Id = 3,
                ProductName = "Keyboard",
                Quantity = 1,
                UnitPrice = 1500
            };

            // Add all 3 items
            cartService.AddItem(item1);
            cartService.AddItem(item2);
            cartService.AddItem(item3);

            // Calculate total before removing anything
            decimal totalBeforeRemove = cartService.CalculateTotal();

            Console.WriteLine("Total before removal: " + totalBeforeRemove);

            // Remove Mouse (Id = 2)
            cartService.RemoveItem(2);

            // Calculate total again
            decimal totalAfterRemove = cartService.CalculateTotal();

            Console.WriteLine("Total after removal: " + totalAfterRemove);
        }
    }
}