using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Coin
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