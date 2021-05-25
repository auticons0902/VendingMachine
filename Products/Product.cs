using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Products
{
    class Product
    {
        public virtual string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        protected Product() { }
    }
}