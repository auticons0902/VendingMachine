using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VendingMachine.Product;
using VendingMachine.Coin;

namespace VendingMachine.Machine
{
    class VendingMachine
    {
        public virtual List<Coin> Coins { get; protected set; }
        public virtual List<Product> Products { get; protected set; }

        protected VendingMachine() { }
        protected virtual Dictionary<string, int> GetProductInfo(string name) { }
        protected virtual Dictionary<string, int> PurchaseProducts(Dictionary<string, int> productOrder, Dictionary<string, int> incomingCoins) { }
        protected virtual Dictionary<string, int> MakeChange(int amount) { }
        protected virtual void AddProductQuantity(string name, int quantityToAdd) { }
        protected virtual void AddCoinQuantity(string name, int quantityToAdd) { }
        protected virtual Dictionary<string, int> GetCoinInfo(string name) { }
    }
}
