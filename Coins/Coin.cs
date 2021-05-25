using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Coins
{
    class Coin
    {
        public virtual String Name { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int Value { get; set; }

        protected Coin() { }
    }
}