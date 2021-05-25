using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Coins
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