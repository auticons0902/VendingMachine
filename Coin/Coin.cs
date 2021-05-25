using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Coin
{
    class Collections
    {
        public virtual String Name { get; protected set; }
        public virtual int Quantity { get; set; }
        public virtual int Value { get; set; }

        protected Coin() { }
    }
}