using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Product
{
    class Pepsis : Product
    {
        public Pepsis(int quantity) 
        {
            Quantity = quantity;
            Price = 36;
            Name = "Pepsis";
        }
    }
}