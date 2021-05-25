using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Products
{
    class Pepsis : Product
    {
        public Pepsis(int quantity) 
        {
            Quantity = quantity;
            Price = 36;
            Name = "Pepsi";
        }
    }
}