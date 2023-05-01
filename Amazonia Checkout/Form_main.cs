using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazonia_Checkout
{
    public partial class MainForm : Form
    {
        public static User User;
        public static ObservableCollection<Item> Cart = new ObservableCollection<Item>();
        public static bool logoutCollapsed = true;
        public static bool settingsCollapsed = true;

        public MainForm()
        {
            AC_Main.OpenApp = false;

            Login();
            InitializeComponent();           
            InitializeShop();
            UpdateCartDisplay();
            Cart.CollectionChanged += CartUpdated;
        }


        public void DisplayPanel(Control panel)
        {
            foreach(Control control in this.Controls)
            {
                if(control is FlowLayoutPanel || control.Name == "itemInfoPanel")
                {
                    if(control.Name == panel.Name)
                    {
                        control.Visible = true;
                    }
                    else
                    {
                        control.Visible = false;
                    }

                    if(control.Name == "itemPanel")
                    {
                        foreach(Form_itemDisplay id in AC_Main.main.itemPanel.Controls)
                        {
                            id.CheckCartStatus();
                        }
                    }
                }
                if (!logoutCollapsed)
                {
                    logoutDDTimer.Start();
                }
                if (!settingsCollapsed)
                {
                    settingsDDTimer.Start();
                }
            }
        }

        private void Login()
        {
            Form_Login login = new Form_Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private async void InitializeShop()
        {
            List<Item> items = await API_Interface.GetShopItems();
            foreach (Item item in items)
            {
                item.LoadImages();
                Form_itemDisplay displayItem = new Form_itemDisplay(item)
                {
                    Dock = DockStyle.Top,
                    TopLevel = false,
                    TopMost = true,
                    Visible = true
                };

                itemPanel.Controls.Add(displayItem);
            }

            SyncCart();
        }

        public void DisplayItemInfo(Item item)
        {

            itemInfoPanel.Controls.Clear();

            ItemInfoView displayItem = new ItemInfoView(item)
            {
                TopLevel = false,
                TopMost = true,
                Visible = true
            };
            itemInfoPanel.Controls.Add(displayItem);
            displayItem.Dock = DockStyle.Fill;
            
            DisplayPanel(itemInfoPanel);
        }

        public void CloseItemInfo()
        {
            DisplayPanel(itemPanel);
        }

        public async void SyncCart(bool updateCart = true)
        {
            List<Item> ServerCart = await API_Interface.GetCart(User.ID);

            if(ServerCart.Count > 0)
            {
               foreach(var item in ServerCart)
               {
                    foreach(Form_itemDisplay itemD in itemPanel.Controls)
                    {
                        if(itemD.GetItem.Name == item.Name)
                        {
                            itemD.InitializeCart(item.CartQty, updateCart);
                        }
                    }
               }
            }
        }

        public void UpdateCart(Item item, int qty)
        {
            foreach(Item cartItem in Cart)
            {
                if(item.ID == cartItem.ID)
                {
                    Cart.Remove(cartItem);
                    break;
                }
            }

            if (qty > 0)
            {
                item.CartQty = qty;
                Cart.Add(item);
            }

            _ = API_Interface.UpdateCart(User.ID, item.ID, qty);
        }

        private void CartUpdated(object sender, NotifyCollectionChangedEventArgs e)
        {
            UpdateCartDisplay();
        }

        public void UpdateCartDisplay()
        {
            if (Cart.Count > 0)
            {
                int totalQty = 0;
                 foreach(Item item in Cart)
                {
                    totalQty += item.CartQty;
                }
                cartQtyLabel.Text = totalQty.ToString();
                if(totalQty > 99)
                {
                    cartQtyLabel.Text = "99+";
                }
                cartQtyLabel.Visible = true;
            }
            else
            {
                cartQtyLabel.Visible = false;
            }
        }

        private void ShoppingCart_Click(object sender, EventArgs e)
        {
            DisplayPanel(cartPanel);

            cartPanel.Controls.Clear();

            foreach (Item item in Cart)
            {
                CartView displayItem = new CartView(item)
                {
                    AutoSize = true,
                    TopLevel = false,
                    TopMost = true,
                    Visible = true
                };
                cartPanel.Controls.Add(displayItem);
                displayItem.Dock = DockStyle.Top;
            }
            int totalItems = 0;
            decimal totalPrice = 0;
            
            foreach(CartView control in cartPanel.Controls)
            {
                totalItems += control.CartQty;
                totalPrice += control.TotalPrice;
            }


            CartTotal cartTotal = new CartTotal(totalItems, totalPrice)
            {
                AutoSize = true,
                TopLevel = false,
                TopMost = true,
                Visible = true
            };
            cartPanel.Controls.Add(cartTotal);
            cartTotal.Dock = DockStyle.Top;
        }

        private void profile_Click(object sender, EventArgs e)
        {
            if (!settingsCollapsed)
            {
                settingsDDTimer.Start();
            }
            if (logoutCollapsed)
            {
                logoutPanel.Visible = true;
            }
            logoutDDTimer.Start();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (!logoutCollapsed)
            {
                logoutDDTimer.Start();
            }
            if (settingsCollapsed)
            {
                settingsPanel.Visible = true;
            }
            settingsDDTimer.Start();
        }

        private void LogoutDDTimer_Tick(object sender, EventArgs e)
        {
            int totalTicks = 10;
            int sizeAdjustment = logoutPanel.MaximumSize.Height / totalTicks;

            if (logoutCollapsed)
            {
                logoutPanel.Height += sizeAdjustment;
                if(logoutPanel.Height == logoutPanel.MaximumSize.Height)
                {
                    logoutDDTimer.Stop();
                    logoutCollapsed = false;
                }
            }
            else
            {
                logoutPanel.Height -= sizeAdjustment;
                if (logoutPanel.Height == 0)
                {
                    logoutDDTimer.Stop();
                    logoutCollapsed = true;
                    logoutPanel.Visible = false;
                }
            }
        }

        private void SettingsDDTimer_Tick(object sender, EventArgs e)
        {
            if (settingsCollapsed)
            {
                settingsPanel.Height += 2;
                if (settingsPanel.Height == settingsPanel.MaximumSize.Height)
                {
                    settingsDDTimer.Stop();
                    settingsCollapsed = false;
                }
            }
            else
            {
                settingsPanel.Height -= 2;
                if (settingsPanel.Height == 0)
                {
                    settingsDDTimer.Stop();
                    settingsCollapsed = true;
                    settingsPanel.Visible = false;
                }
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (!logoutCollapsed)
            {
                logoutDDTimer.Start();
            }

            var response = MessageBox.Show("Are you sure you want to log out?", "Are you sure?", MessageBoxButtons.YesNo);
            
            if(response == DialogResult.Yes)
            {                
                SettingsHandler.RemoveUserSettings();
                Cart.Clear();
                AC_Main.OpenApp = true;
                this.Close();
                
            }
        }

        private void DAL_Button_Click(object sender, EventArgs e)
        {
            if (!settingsCollapsed)
            {
                settingsDDTimer.Start();
            }

            SettingsHandler.RemoveUserSettings();
            if (!SettingsHandler.CheckSettingsExist())
            {
                MessageBox.Show("Auto-login disabled!", "Success", MessageBoxButtons.OK);
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            if (itemInfoPanel.Visible)
            {
                SyncCart(false);
                itemInfoPanel.Controls.Clear();
            }
            if (cartPanel.Visible)
            {
                SyncCart(false);
                cartPanel.Controls.Clear();
            }
            DisplayPanel(itemPanel);
        }

        private void CartControlsChanged(object sender, ControlEventArgs e)
        {
            var cartTotal = AC_Main.main.cartPanel.Controls.OfType<CartTotal>().LastOrDefault();
            if (cartTotal != null)
            {
                cartTotal.GetItemInfo();
            }
        }
    }
}
