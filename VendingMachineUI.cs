using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Machines;

namespace VendingMachine
{
    public partial class VendingMachineUI : Form
    {
        public VendingMachineUI()
        {
            drinksMachine = new DrinksMachine();
            InitializeComponent();
            RefreshInventory();
        }

        public void RefreshInventory()
        {
            var cokeInfo = drinksMachine.GetProductInfo("Coke");
            CokeInfoLabel.Text = $"{cokeInfo["quantity"]} drinks available, Cost = {cokeInfo["price"]}₵";
            CokeInput.Maximum = cokeInfo["quantity"];
            CokeInput.Value = 0;

            var pepsiInfo = drinksMachine.GetProductInfo("Pepsi");
            PepsiInfoLabel.Text = $"{pepsiInfo["quantity"]} drinks available, Cost = {pepsiInfo["price"]}₵";
            PepsiInput.Maximum = pepsiInfo["quantity"];
            PepsiInput.Value = 0;

            var sodaInfo = drinksMachine.GetProductInfo("Soda");
            SodaInfoLabel.Text = $"{sodaInfo["quantity"]} drinks available, Cost = {sodaInfo["price"]}₵";
            SodaInput.Maximum = sodaInfo["quantity"];
            SodaInput.Value = 0;

            PenniesInput.Value = 0;
            NickelsInput.Value = 0;
            DimesInput.Value = 0;
            QuartersInput.Value = 0;
        }

        public void SetTotalOrderPrice()
        {
            var cokeInfo = drinksMachine.GetProductInfo("Coke");
            var pepsiInfo = drinksMachine.GetProductInfo("Pepsi");
            var sodaInfo = drinksMachine.GetProductInfo("Soda");

            int totalCost = Convert.ToInt32(
                CokeInput.Value * cokeInfo["price"] + 
                PepsiInput.Value * pepsiInfo["price"] + 
                SodaInput.Value * sodaInfo["price"]
            );

            OrderTotalInfoLabel.Text = $" ${totalCost / 100} and {totalCost % 100}₵";
        }

        private void CokeInput_ValueChanged(object sender, EventArgs e)
        {
            SetTotalOrderPrice();
        }

        private void PepsiInput_ValueChanged(object sender, EventArgs e)
        {
            SetTotalOrderPrice();
        }

        private void SodaInput_ValueChanged(object sender, EventArgs e)
        {
            SetTotalOrderPrice();
        }

        private void GetDrinksButton_Click(object sender, EventArgs e)
        {
            var cokeInfo = drinksMachine.GetProductInfo("Coke");
            var pepsiInfo = drinksMachine.GetProductInfo("Pepsi");
            var sodaInfo = drinksMachine.GetProductInfo("Soda");

            int totalCost = Convert.ToInt32(
                CokeInput.Value * cokeInfo["price"] +
                PepsiInput.Value * pepsiInfo["price"] +
                SodaInput.Value * sodaInfo["price"]
            );

            if (totalCost == 0) return;

            string orderSummary = "Order Summary:\n";

            if (CokeInput.Value > 0) orderSummary += $"{CokeInput.Value} Coke(s) @ {cokeInfo["price"]}₵ each\n";
            if (PepsiInput.Value > 0) orderSummary += $"{PepsiInput.Value} Pepsi(s) @ {pepsiInfo["price"]}₵ each\n";
            if (SodaInput.Value > 0) orderSummary += $"{SodaInput.Value} Soda(s) @ {sodaInfo["price"]}₵ each\n";

            orderSummary += $"Total Cost: ${totalCost / 100} and {totalCost % 100}₵";

            var confirmationResult = MessageBox.Show(orderSummary, "Confirm Purchase", MessageBoxButtons.OKCancel);

            if (confirmationResult == DialogResult.OK) {
                var productsToOrder = new Dictionary<string, int>() {
                    ["Coke"] = Convert.ToInt32(CokeInput.Value),
                    ["Pepsi"] = Convert.ToInt32(PepsiInput.Value),
                    ["Soda"] = Convert.ToInt32(SodaInput.Value)
                };

                var coinsUsed = new Dictionary<string, int>() {
                    ["Pennies"] = Convert.ToInt32(PenniesInput.Value),
                    ["Nickels"] = Convert.ToInt32(NickelsInput.Value),
                    ["Dimes"] = Convert.ToInt32(DimesInput.Value),
                    ["Quarters"] = Convert.ToInt32(QuartersInput.Value),
                };

                try {
                    var change = drinksMachine.PurchaseProducts(productsToOrder, coinsUsed);

                    string changeList = "Change: \n";

                    foreach(var c in change) {
                        changeList += $"{c.Key}: {c.Value}\n";
                    }

                    if (changeList == "Change: \n") changeList = "No change returned.";

                    MessageBox.Show(changeList);
                    RefreshInventory();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}
