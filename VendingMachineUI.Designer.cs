using VendingMachine.Machines;

namespace VendingMachine
{
    partial class VendingMachineUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DrinksMachine drinksMachine;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.PenniesInput = new System.Windows.Forms.NumericUpDown();
            this.NickelsInput = new System.Windows.Forms.NumericUpDown();
            this.DimesInput = new System.Windows.Forms.NumericUpDown();
            this.QuartersInput = new System.Windows.Forms.NumericUpDown();
            this.PenniesLabel = new System.Windows.Forms.Label();
            this.NicklesLabel = new System.Windows.Forms.Label();
            this.DimesLabel = new System.Windows.Forms.Label();
            this.QuartersLabel = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.CokeLabel = new System.Windows.Forms.Label();
            this.CokeInput = new System.Windows.Forms.NumericUpDown();
            this.CokeInfoLabel = new System.Windows.Forms.Label();
            this.PepsiLabel = new System.Windows.Forms.Label();
            this.PepsiInput = new System.Windows.Forms.NumericUpDown();
            this.PepsiInfoLabel = new System.Windows.Forms.Label();
            this.SodaLabel = new System.Windows.Forms.Label();
            this.SodaInput = new System.Windows.Forms.NumericUpDown();
            this.SodaInfoLabel = new System.Windows.Forms.Label();
            this.OrderTotalLabel = new System.Windows.Forms.Label();
            this.OrderTotalInfoLabel = new System.Windows.Forms.Label();
            this.GetDrinksButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PenniesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NickelsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DimesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuartersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CokeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PepsiInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SodaInput)).BeginInit();
            this.SuspendLayout();
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.AutoSize = true;
            this.CoinsLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CoinsLabel.Location = new System.Drawing.Point(12, 9);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(240, 30);
            this.CoinsLabel.TabIndex = 0;
            this.CoinsLabel.Text = "COINS INFORMATION";
            // 
            // PenniesInput
            // 
            this.PenniesInput.Location = new System.Drawing.Point(12, 72);
            this.PenniesInput.Name = "PenniesInput";
            this.PenniesInput.Size = new System.Drawing.Size(120, 23);
            this.PenniesInput.TabIndex = 1;
            // 
            // NickelsInput
            // 
            this.NickelsInput.Location = new System.Drawing.Point(138, 72);
            this.NickelsInput.Name = "NickelsInput";
            this.NickelsInput.Size = new System.Drawing.Size(120, 23);
            this.NickelsInput.TabIndex = 2;
            // 
            // DimesInput
            // 
            this.DimesInput.Location = new System.Drawing.Point(264, 72);
            this.DimesInput.Name = "DimesInput";
            this.DimesInput.Size = new System.Drawing.Size(120, 23);
            this.DimesInput.TabIndex = 3;
            // 
            // QuartersInput
            // 
            this.QuartersInput.Location = new System.Drawing.Point(390, 72);
            this.QuartersInput.Name = "QuartersInput";
            this.QuartersInput.Size = new System.Drawing.Size(120, 23);
            this.QuartersInput.TabIndex = 4;
            // 
            // PenniesLabel
            // 
            this.PenniesLabel.AutoSize = true;
            this.PenniesLabel.Location = new System.Drawing.Point(12, 54);
            this.PenniesLabel.Name = "PenniesLabel";
            this.PenniesLabel.Size = new System.Drawing.Size(48, 15);
            this.PenniesLabel.TabIndex = 5;
            this.PenniesLabel.Text = "Pennies";
            // 
            // NicklesLabel
            // 
            this.NicklesLabel.AutoSize = true;
            this.NicklesLabel.Location = new System.Drawing.Point(138, 54);
            this.NicklesLabel.Name = "NicklesLabel";
            this.NicklesLabel.Size = new System.Drawing.Size(45, 15);
            this.NicklesLabel.TabIndex = 6;
            this.NicklesLabel.Text = "Nickels";
            // 
            // DimesLabel
            // 
            this.DimesLabel.AutoSize = true;
            this.DimesLabel.Location = new System.Drawing.Point(264, 54);
            this.DimesLabel.Name = "DimesLabel";
            this.DimesLabel.Size = new System.Drawing.Size(40, 15);
            this.DimesLabel.TabIndex = 7;
            this.DimesLabel.Text = "Dimes";
            // 
            // QuartersLabel
            // 
            this.QuartersLabel.AutoSize = true;
            this.QuartersLabel.Location = new System.Drawing.Point(390, 54);
            this.QuartersLabel.Name = "QuartersLabel";
            this.QuartersLabel.Size = new System.Drawing.Size(52, 15);
            this.QuartersLabel.TabIndex = 8;
            this.QuartersLabel.Text = "Quarters";
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsLabel.Location = new System.Drawing.Point(12, 150);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(289, 30);
            this.ProductsLabel.TabIndex = 9;
            this.ProductsLabel.Text = "PRODUCTS INFORMATION";
            // 
            // CokeLabel
            // 
            this.CokeLabel.AutoSize = true;
            this.CokeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CokeLabel.Location = new System.Drawing.Point(12, 204);
            this.CokeLabel.Name = "CokeLabel";
            this.CokeLabel.Size = new System.Drawing.Size(48, 21);
            this.CokeLabel.TabIndex = 10;
            this.CokeLabel.Text = "Coke";
            // 
            // CokeInput
            // 
            this.CokeInput.Location = new System.Drawing.Point(138, 202);
            this.CokeInput.Name = "CokeInput";
            this.CokeInput.Size = new System.Drawing.Size(120, 23);
            this.CokeInput.TabIndex = 11;
            this.CokeInput.ValueChanged += new System.EventHandler(this.CokeInput_ValueChanged);
            // 
            // CokeInfoLabel
            // 
            this.CokeInfoLabel.AutoSize = true;
            this.CokeInfoLabel.Location = new System.Drawing.Point(12, 235);
            this.CokeInfoLabel.Name = "CokeInfoLabel";
            this.CokeInfoLabel.Size = new System.Drawing.Size(35, 15);
            this.CokeInfoLabel.TabIndex = 12;
            this.CokeInfoLabel.Text = "Hello";
            // 
            // PepsiLabel
            // 
            this.PepsiLabel.AutoSize = true;
            this.PepsiLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PepsiLabel.Location = new System.Drawing.Point(12, 267);
            this.PepsiLabel.Name = "PepsiLabel";
            this.PepsiLabel.Size = new System.Drawing.Size(51, 21);
            this.PepsiLabel.TabIndex = 13;
            this.PepsiLabel.Text = "Pepsi";
            // 
            // PepsiInput
            // 
            this.PepsiInput.Location = new System.Drawing.Point(138, 267);
            this.PepsiInput.Name = "PepsiInput";
            this.PepsiInput.Size = new System.Drawing.Size(120, 23);
            this.PepsiInput.TabIndex = 14;
            this.PepsiInput.ValueChanged += new System.EventHandler(this.PepsiInput_ValueChanged);
            // 
            // PepsiInfoLabel
            // 
            this.PepsiInfoLabel.AutoSize = true;
            this.PepsiInfoLabel.Location = new System.Drawing.Point(12, 299);
            this.PepsiInfoLabel.Name = "PepsiInfoLabel";
            this.PepsiInfoLabel.Size = new System.Drawing.Size(35, 15);
            this.PepsiInfoLabel.TabIndex = 15;
            this.PepsiInfoLabel.Text = "Hello";
            // 
            // SodaLabel
            // 
            this.SodaLabel.AutoSize = true;
            this.SodaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SodaLabel.Location = new System.Drawing.Point(12, 332);
            this.SodaLabel.Name = "SodaLabel";
            this.SodaLabel.Size = new System.Drawing.Size(48, 21);
            this.SodaLabel.TabIndex = 16;
            this.SodaLabel.Text = "Soda";
            // 
            // SodaInput
            // 
            this.SodaInput.Location = new System.Drawing.Point(138, 335);
            this.SodaInput.Name = "SodaInput";
            this.SodaInput.Size = new System.Drawing.Size(120, 23);
            this.SodaInput.TabIndex = 17;
            this.SodaInput.ValueChanged += new System.EventHandler(this.SodaInput_ValueChanged);
            // 
            // SodaInfoLabel
            // 
            this.SodaInfoLabel.AutoSize = true;
            this.SodaInfoLabel.Location = new System.Drawing.Point(12, 368);
            this.SodaInfoLabel.Name = "SodaInfoLabel";
            this.SodaInfoLabel.Size = new System.Drawing.Size(35, 15);
            this.SodaInfoLabel.TabIndex = 18;
            this.SodaInfoLabel.Text = "Hello";
            // 
            // OrderTotalLabel
            // 
            this.OrderTotalLabel.AutoSize = true;
            this.OrderTotalLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderTotalLabel.Location = new System.Drawing.Point(454, 223);
            this.OrderTotalLabel.Name = "OrderTotalLabel";
            this.OrderTotalLabel.Size = new System.Drawing.Size(163, 30);
            this.OrderTotalLabel.TabIndex = 19;
            this.OrderTotalLabel.Text = "ORDER TOTAL:";
            // 
            // OrderTotalInfoLabel
            // 
            this.OrderTotalInfoLabel.AutoSize = true;
            this.OrderTotalInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OrderTotalInfoLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderTotalInfoLabel.Location = new System.Drawing.Point(614, 225);
            this.OrderTotalInfoLabel.Name = "OrderTotalInfoLabel";
            this.OrderTotalInfoLabel.Size = new System.Drawing.Size(46, 25);
            this.OrderTotalInfoLabel.TabIndex = 20;
            this.OrderTotalInfoLabel.Text = "0.00";
            // 
            // GetDrinksButton
            // 
            this.GetDrinksButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetDrinksButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetDrinksButton.Location = new System.Drawing.Point(581, 368);
            this.GetDrinksButton.Name = "GetDrinksButton";
            this.GetDrinksButton.Size = new System.Drawing.Size(167, 60);
            this.GetDrinksButton.TabIndex = 21;
            this.GetDrinksButton.Text = "Get Drinks";
            this.GetDrinksButton.UseVisualStyleBackColor = false;
            this.GetDrinksButton.Click += new System.EventHandler(this.GetDrinksButton_Click);
            // 
            // VendingMachineUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetDrinksButton);
            this.Controls.Add(this.OrderTotalInfoLabel);
            this.Controls.Add(this.OrderTotalLabel);
            this.Controls.Add(this.SodaInfoLabel);
            this.Controls.Add(this.SodaInput);
            this.Controls.Add(this.SodaLabel);
            this.Controls.Add(this.PepsiInfoLabel);
            this.Controls.Add(this.PepsiInput);
            this.Controls.Add(this.PepsiLabel);
            this.Controls.Add(this.CokeInfoLabel);
            this.Controls.Add(this.CokeInput);
            this.Controls.Add(this.CokeLabel);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.QuartersLabel);
            this.Controls.Add(this.DimesLabel);
            this.Controls.Add(this.NicklesLabel);
            this.Controls.Add(this.PenniesLabel);
            this.Controls.Add(this.QuartersInput);
            this.Controls.Add(this.DimesInput);
            this.Controls.Add(this.NickelsInput);
            this.Controls.Add(this.PenniesInput);
            this.Controls.Add(this.CoinsLabel);
            this.Name = "VendingMachineUI";
            this.Text = "Vending Machine";
            ((System.ComponentModel.ISupportInitialize)(this.PenniesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NickelsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DimesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuartersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CokeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PepsiInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SodaInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoinsLabel;
        private System.Windows.Forms.NumericUpDown PenniesInput;
        private System.Windows.Forms.NumericUpDown NickelsInput;
        private System.Windows.Forms.NumericUpDown DimesInput;
        private System.Windows.Forms.NumericUpDown QuartersInput;
        private System.Windows.Forms.Label PenniesLabel;
        private System.Windows.Forms.Label NicklesLabel;
        private System.Windows.Forms.Label DimesLabel;
        private System.Windows.Forms.Label QuartersLabel;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Label CokeLabel;
        private System.Windows.Forms.NumericUpDown CokeInput;
        private System.Windows.Forms.Label CokeInfoLabel;
        private System.Windows.Forms.Label PepsiLabel;
        private System.Windows.Forms.NumericUpDown PepsiInput;
        private System.Windows.Forms.Label PepsiInfoLabel;
        private System.Windows.Forms.Label SodaLabel;
        private System.Windows.Forms.NumericUpDown SodaInput;
        private System.Windows.Forms.Label SodaInfoLabel;
        private System.Windows.Forms.Label OrderTotalLabel;
        private System.Windows.Forms.Label OrderTotalInfoLabel;
        private System.Windows.Forms.Button GetDrinksButton;
    }
}

