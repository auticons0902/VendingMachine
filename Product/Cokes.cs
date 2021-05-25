using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Product
{
    class Cokes : Product
    {
        public Cokes(int quantity) 
        {
            Quantity = quantity;
            Price = 25;
            Name = "Cokes";
        }
    }
}