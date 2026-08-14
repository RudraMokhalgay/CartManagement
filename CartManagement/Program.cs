using CartManagement.Models;
using CartManagement.Repositories;
using CartManagement.Services;

class Program
{
    static void Main(string[] args)
    {
        CartRepository cartRepository = new CartRepository();

        CartService cartService = new CartService(cartRepository);

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

        cartService.AddItem(item1);
        cartService.AddItem(item2);

        decimal total = cartService.CalculateTotal();

        Console.WriteLine("Cart Total: " + total);
    }
}