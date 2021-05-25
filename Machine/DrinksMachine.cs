using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using VendingMachine.Product;
using VendingMachine.Coin;

namespace VendingMachine.Machine
{
    class DrinksMachine : VendingMachine
    {
        public DrinksMachine() 
        {
            Coins = new List<Coin> {
                new Pennies(100),
                new Nickels(10),
                new Dimes(5),
                new Quarters(25)
            };
            Coins = Coins.OrderByDescending(c => c.Value).ToList();

            Products = new List<Product> {
                new Cokes(5),
                new Pepsis(15),
                new Sodas(3)
            };
        }

        public Dictionary<string, int> GetProductInfo(string name)
        {
            foreach (Product p in Products) {
                if (p.Name == name) {
                    return new Dictionary<string, int>() { 
                        ["price"] = p.Price,
                        ["quantity"] = p.Quantity 
                    };
                }
            }
            throw new KeyNotFoundException("No products exist with given name");
        }

        public Dictionary<string, int> PurchaseProducts(Dictionary<string, int> productOrder, Dictionary<string, int> incomingCoins)
        {
            var totalCost = 0;

            foreach (var p in productOrder) {
                var info = GetProductInfo(p.Key);
                totalCost += info["price"] * p.Value;
            }

            var totalCoinValue = 0;

            foreach (var c in incomingCoins) {
                var info = GetCoinInfo(c.Key);
                totalCoinValue += info["value"] * c.Value;
            }

            if (totalCoinValue < totalCost) throw new Exception("Not enough coins to purchase drinks");

            var changeNeeded = totalCoinValue - totalCost;

            if (changeNeeded > 0) {
                var change = MakeChange(changeNeeded);

                foreach (var p in productOrder) {
                    ModProductQuantity(p.Key, -1 * p.Value);
                }

                foreach (var c in incomingCoins) {
                    ModCoinQuantity(c.Key, c.Value);
                }

                return change;
            } else {
                foreach (var p in productOrder) {
                    ModProductQuantity(p.Key, -1 * p.Value);
                }

                foreach (var c in incomingCoins) {
                    ModCoinQuantity(c.Key, c.Value);
                }

                return new Dictionary<string, int>();
            }
        }

        protected Dictionary<string, int> MakeChange(int amount)
        {
            var _amount = amount;
            Dictionary<string, int> change = new Dictionary<string, int>();

            foreach (Coin c in Coins) {
                var coinsNeeded = Math.Min(_amount / c.Value, c.Quantity);
                _amount -= coinsNeeded * c.Value;
            }

            if (_amount > 0)  {
                throw new Exception("Not sufficient change in the inventory");
            }

            _amount = amount;

            foreach (Coin c in Coins) {
                var coinsNeeded = Math.Min(_amount / c.Value, c.Quantity);
                change[c.Name] = coinsNeeded;
                ModCoinQuantity(c.Name, -1 * coinsNeeded);
                _amount -= coinsNeeded * c.Value;
            }

            return change;
        }

        protected void ModProductQuantity(string name, int quantityToMod)
        {
            foreach (Product p in Products) {
                if (p.Name == name) {
                    p.Quantity += quantityToMod;
                }
            }
        }

        protected void ModCoinQuantity(string name, int quantityToMod)
        {
            foreach (Coin c in Coins) {
                if (c.Name == name) {
                    c.Quantity += quantityToMod;
                }
            }
        }

        protected Dictionary<string, int> GetCoinInfo(string name)
        {
            foreach (Coin c in Coins) {
                if (c.Name == name) {
                    return new Dictionary<string, int>() {
                        ["value"] = c.Value,
                        ["quantity"] = c.Quantity
                    };
                }
            }
            throw new KeyNotFoundException("No products exist with given name");
        }

    }
}
