using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Amazonia_Checkout
{
    public partial class CartTotal : Form
    {
        private int itemCount;
        private decimal totalCost;

        public CartTotal(int totalItems, decimal totalPrice)
        {
            itemCount = totalItems;
            totalCost = totalPrice;
            InitializeComponent();
            UpdateInfo(itemCount, totalCost);
        }

        public void UpdateInfo(int totalItems, decimal totalPrice)
        {
            totalPriceLabel.Text = "$" + totalPrice.ToString("0.00");
            totalItemsLabel.Text = $"({totalItems} items)";
        }

        public void GetItemInfo()
        {
            int totalItems = 0;
            decimal totalPrice = 0;

            foreach (CartView control in AC_Main.main.cartPanel.Controls.OfType<CartView>())
            {
                totalItems += control.CartQty;
                totalPrice += control.TotalPrice;
            }

            UpdateInfo(totalItems, totalPrice);
        }

        private void checkoutButton_MouseEnter(object sender, EventArgs e)
        {
            checkoutButton.ImageIndex = 2;
        }

        private void checkoutButton_MouseLeave(object sender, EventArgs e)
        {
            checkoutButton.ImageIndex = 0;
        }

        private void checkoutButton_MouseDown(object sender, MouseEventArgs e)
        {
            checkoutButton.ImageIndex = 1;
        }

        private void checkoutButton_MouseUp(object sender, MouseEventArgs e)
        {
            checkoutButton.ImageIndex = 2;
        }

        private async void checkoutButton_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show($"Are you ready to check out {itemCount} item(s) for ${totalCost.ToString("0.00")}?", "Ready to check out?", MessageBoxButtons.YesNo);
            
            if(response == DialogResult.Yes)
            {
                await API_Interface.Checkout(MainForm.User.ID);
                MainForm.Cart.Clear();
                AC_Main.main.DisplayPanel(AC_Main.main.itemPanel);
                Random r = new Random();
                MessageBox.Show($"Order {r.Next(99999) + 10000} submitted successfully! Your order will be shipped to the address on file.", "Thank you!", MessageBoxButtons.OK);
            }
        }
    }
}
