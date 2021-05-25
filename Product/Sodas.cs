using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Product
{
    class Sodas : Product
    {
        public Sodas(int quantity) 
        {
            Quantity = quantity;
            Price = 45;
            Name = "Sodas";
        }
    }
}