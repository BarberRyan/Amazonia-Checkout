using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Amazonia_Checkout
{
    public partial class Form_itemDisplay : Form
    {
        public Item GetItem { get; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string CurPrice { get; set; }
        public string OldPrice { get; set; }
        public int ShopQty { get; set; }

        private int ImageCount = 0;
        private int ImageIndex = 0;
        private bool active = true;

        public Form_itemDisplay(Item input)
        {
            GetItem = input;
            ItemID = input.ID;
            ItemName = input.Name;
            CurPrice = input.Price.ToString("0.00");
            OldPrice = input.OldPrice.ToString("0.00");
            ShopQty = input.Qty;
            InitializeComponent();
            SetImages(input.Images);
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            itemNameLabel.Text = ItemName;
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
            if(GetItem.Qty == 0)
            {
                removeCartPanel.Visible = true;
                this.active = false;
                removeLabel.Text = "  OUT OF STOCK";
                removeCartPanel.Cursor = Cursors.Default;
            }
        }

        private void SetImages(List<Image> imgList)
        {

            if (imgList != null)
            {
                foreach (Image img in imgList)
                {
                    itemImages.Images.Add(img);
                }
            }

            if (itemImages.Images.Count > 0)
            {
                ImageCount = itemImages.Images.Count;
                imageView.Image = itemImages.Images[0];
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
                imageView.Image = itemImages.Images[ImageIndex];
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
                imageView.Image = itemImages.Images[ImageIndex];
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

        public void InitializeCart(int qty, bool addToCart = true)
        {
            if (addToCart)
            {
                GetItem.CartQty = qty;
                AC_Main.main.UpdateCart(GetItem, qty);
            }
            CheckCartStatus();
        }

        private void AddToCart(object sender, MouseEventArgs e)
        {
            addCartPanel.Visible = false;
            removeCartPanel.Visible = true;
            InitializeCart(1);
            this.Focus();

        }

        private void RemoveFromCart(object sender, MouseEventArgs e)
        {
            if (active)
            {
                addCartPanel.Visible = true;
                removeCartPanel.Visible = false;
                AC_Main.main.UpdateCart(GetItem, 0);
                this.Focus();
            }
            CheckCartStatus();
        }

        public void CheckCartStatus()
        {
            addCartPanel.Visible = true;
            removeCartPanel.Visible = false;

            foreach (Item item in MainForm.Cart)
            {
                if (item.ID == GetItem.ID)
                {
                    addCartPanel.Visible = false;
                    removeCartPanel.Visible = true;
                }
            }
        }

        private void OpenInfoView(object sender, EventArgs e)
        {
            AC_Main.main.DisplayItemInfo(GetItem);
        }
    }
}
