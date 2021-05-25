using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Coins
{
    class Quarters : Coin
    {
        public Quarters(int quantity)
        {
            Quantity = quantity;
            Value = 25;
            Name = "Quarters";
        }
    }
}