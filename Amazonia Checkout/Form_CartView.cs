using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazonia_Checkout
{
    public partial class CartView : Form
    {
        public Item GetItem { get; set; }
        public int CartQty { get; set; }
        private decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public CartView(Item item)
        {
            GetItem = item;
            CartQty = item.CartQty;
            UnitPrice = item.Price;
            TotalPrice = CartQty * UnitPrice;

            InitializeComponent();
            DisplayInfo();
            SetCartQty();
            cartQtySelect.SelectedIndexChanged += CartQtyChanged;
        }

        private void SetCartQty()
        {
            foreach (Item item in MainForm.Cart)
            {
                if (item.ID == GetItem.ID)
                {
                    CartQty = item.CartQty;
                }
            }
            for (int i = -1; i < GetItem.Qty && i < 99; i++)
            {
                cartQtySelect.Items.Add(i + 1);
            }
            cartQtySelect.SelectedIndex = GetItem.CartQty;
        }

        private void DisplayInfo()
        {
            itemNameLabel.Text = GetItem.Name;
            if(GetItem.Images != null && GetItem.Images.Count > 0)
            {
                imageBox.Image = GetItem.Images[0];
            }
            priceLabel.Text = "$" + TotalPrice.ToString("0.00");
        }

        private void UpdateDisplayPrice()
        {
            CartQty = cartQtySelect.SelectedIndex;
            TotalPrice = CartQty * UnitPrice;
            priceLabel.Text = "$" + TotalPrice.ToString("0.00");

            var cartTotal = AC_Main.main.cartPanel.Controls.OfType<CartTotal>().LastOrDefault();
            if(cartTotal != null)
            {
                cartTotal.GetItemInfo();
            }
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            AC_Main.main.UpdateCart(GetItem, 0);
            AC_Main.main.SyncCart(false);
            this.Close();
        }

        private void CartQtyChanged(object sender, EventArgs e)
        {
            if (cartQtySelect.SelectedIndex != 0)
            {
                AC_Main.main.UpdateCart(GetItem, cartQtySelect.SelectedIndex);
                UpdateDisplayPrice();
            }
            else
            {
                var response = MessageBox.Show("Do you want to remove this item from your cart?", "Are you sure?", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    AC_Main.main.UpdateCart(GetItem, 0);
                    this.Close();
                }
                else
                {
                    AC_Main.main.UpdateCart(GetItem, 1);
                    cartQtySelect.SelectedIndex = 1;
                }
            }
        }

    }
}
