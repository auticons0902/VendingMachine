using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Products
{
    class Cokes : Product
    {
        public Cokes(int quantity) 
        {
            Quantity = quantity;
            Price = 25;
            Name = "Coke";
        }
    }
}