using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VendingMachine.Products;
using VendingMachine.Coins;

namespace VendingMachine.Machines
{
    abstract class Machine
    {
        public abstract Dictionary<string, int> GetProductInfo(string name);
        public abstract Dictionary<string, int> PurchaseProducts(Dictionary<string, int> productOrder, Dictionary<string, int> incomingCoins);
        public abstract Dictionary<string, int> MakeChange(int amount);
        public abstract void ModProductQuantity(string name, int quantityToMod);
        public abstract void ModCoinQuantity(string name, int quantityToMod);
        public abstract Dictionary<string, int> GetCoinInfo(string name);
    }
}
