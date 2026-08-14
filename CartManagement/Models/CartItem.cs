using System;
using System.Collections.Generic;
using System.Text;

namespace CartManagement.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public required string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

    }
}
