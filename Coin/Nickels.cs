using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Coin
{
    class Nickels : Coin
    {
        public Nickels(int quantity)
        {
            Quantity = quantity;
            Value = 5;
            Name = "Nickels";
        }
    }
}