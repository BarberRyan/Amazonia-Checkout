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
    public partial class ItemInfoView : Form
    {
        public Item GetItem { get; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string CurPrice { get; set; }
        public string OldPrice { get; set; }
        public int Quantity { get; set; }
        public int CartQty { get; set; }

        public string ItemDesc { get; set; }

        private int ImageCount = 0;
        private int ImageIndex = 0;

        private  readonly List<Image> Images = new List<Image>();
        public ItemInfoView(Item input)
        {
            GetItem = input;
            ItemID = input.ID;
            ItemName = input.Name;
            ItemDesc = input.Desc;
            Quantity = input.Qty;
            CurPrice = input.Price.ToString("0.00");
            OldPrice = input.OldPrice.ToString("0.00");
            InitializeComponent();
            SetImages(input.Images);
            DisplayInfo();
            CheckCart();
        }

        private void CheckCart()
        {
            foreach (Item item in MainForm.Cart)
            {
                if (item.ID == ItemID)
                {
                    CartQty = item.CartQty;
                }
                else
                {
                    CartQty = 0;
                }
                InitializeCart(false);
            }
        }

        private void DisplayInfo()
        {
            itemNameLabel.Text = ItemName;
            itemDescLabel.Text = ItemDesc;
            if (OldPrice == "0.00")
            {
                curPriceLabel.Text = $"${CurPrice}";
            }
            else
            {
                curPriceLabel.Text = $"${CurPrice}";
                salePanel.Visible = true;
                oldPriceLabel.Text = $"${OldPrice}";
            }
            if(Quantity == 0)
            {
                stockQtyLabel.Text = "OUT OF STOCK";
                cartQtySelect.Visible = false;
                addCartPanel.Visible = false;
                removeCartPanel.Visible = false;

            }
            else
            {
                stockQtyLabel.Text = $"{Quantity} in stock";
                for(int i = -1; i < Quantity && i < 99; i++)
                {
                    cartQtySelect.Items.Add(i + 1);
                }

                cartQtySelect.SelectedIndex = CartQty;
            }

        }

        private void SetImages(List<Image> imgList)
        {

            if (imgList != null)
            {
                foreach (Image img in imgList)
                {
                    Images.Add(img);
                }
            }

            if (Images.Count > 0)
            {
                ImageCount = Images.Count;
                imageView.Image = Images[0];
                curImgLabel.Text = $"1/{ImageCount}";
            }
            if(ImageCount > 1)
            {
                rightArrow.Enabled = true;
                rightArrow.Image = arrows.Images[1];
            }
            if(ImageCount < 2)
            {
                rightArrow.Visible = false;
                leftArrow.Visible = false;
                curImgLabel.Visible = false;
            }
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            if(ImageIndex < ImageCount - 1)
            {
                ImageIndex++;
                imageView.Image = Images[ImageIndex];
                leftArrow.Enabled = true;
                leftArrow.Image = arrows.Images[0];
                curImgLabel.Text = $"{ImageIndex + 1}/{ImageCount}";
            }
            if(ImageIndex == ImageCount - 1)
            {
                rightArrow.Enabled = false;
                rightArrow.Image = arrows.Images[3];
            }
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            if (ImageIndex > 0)
            {
                ImageIndex--;
                imageView.Image = Images[ImageIndex];
                rightArrow.Enabled = true;
                rightArrow.Image = arrows.Images[1];
                curImgLabel.Text = $"{ImageIndex + 1}/{ImageCount}";
            }
            if(ImageIndex == 0)
            {
                leftArrow.Enabled = false;
                leftArrow.Image = arrows.Images[2];
            }
        }

        public void InitializeCart(bool addToCart = true)
        {
            if (addToCart)
            {
                CartQty = cartQtySelect.SelectedIndex;
                GetItem.CartQty = CartQty;

                addToCartLabel.Text = "Add to cart";
                addCartPanel.Visible = false;
                removeCartPanel.Visible = true;

                AC_Main.main.UpdateCart(GetItem, CartQty);
            }
            else
            {
                if(CartQty > 0)
                {
                    cartQtySelect.SelectedIndex = CartQty;
                    addCartPanel.Visible = false;
                    removeCartPanel.Visible = true;
                }
            }
        }

        private void UpdateCart(object sender, MouseEventArgs e)
        {
            InitializeCart();
        }

        private void RemoveFromCart(object sender, MouseEventArgs e)
        {
                addCartPanel.Visible = true;
                removeCartPanel.Visible = false;
                AC_Main.main.UpdateCart(GetItem, 0);
                cartQtySelect.SelectedIndex = 1;                        
        }

        private void CloseItemView(object sender, EventArgs e)
        {
            AC_Main.main.SyncCart(false);
            AC_Main.main.CloseItemInfo();
        }

        private void CartQtyChange(object sender, EventArgs e)
        {
            foreach(Item item in MainForm.Cart)
            {
                if(item.Name == ItemName && item.CartQty != cartQtySelect.SelectedIndex)
                {
                    if(cartQtySelect.SelectedIndex > 0)
                    {
                        addCartPanel.Visible = true;
                        addToCartLabel.Text = "Update cart";
                        removeCartPanel.Visible = false;
                    }
                    else
                    {
                        addToCartLabel.Text = "Add to cart";
                        addCartPanel.Visible = false;
                        removeCartPanel.Visible = true;
                    }
                }
            }
        }
    }
}
