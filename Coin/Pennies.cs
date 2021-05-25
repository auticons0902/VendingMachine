using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Coin
{
    class Pennies : Coin
    {
        public Pennies(int quantity)
        {
            Quantity = quantity;
            Value = 1;
            Name = "Pennies";
        }
    }
}