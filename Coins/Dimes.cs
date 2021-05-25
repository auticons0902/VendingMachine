using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Coins
{
    class Dimes : Coin
    {
        public Dimes(int quantity)
        {
            Quantity = quantity;
            Value = 10;
            Name = "Dimes";
        }
    }
}