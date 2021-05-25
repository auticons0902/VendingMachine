using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Product
{
    class Product
    {
        public virtual string Name { get; protected set; }
        public int Price { get; protected set; }
        public int Quantity { get; protected set; }

        protected Product() { }
    }
}