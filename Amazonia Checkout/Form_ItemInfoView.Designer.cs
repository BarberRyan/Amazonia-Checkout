namespace Amazonia_Checkout
{
    partial class ItemInfoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInfoView));
            this.arrows = new System.Windows.Forms.ImageList(this.components);
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemDescLabel = new System.Windows.Forms.Label();
            this.curImgLabel = new System.Windows.Forms.Label();
            this.xButton = new System.Windows.Forms.PictureBox();
            this.rightArrow = new System.Windows.Forms.PictureBox();
            this.leftArrow = new System.Windows.Forms.PictureBox();
            this.imageView = new System.Windows.Forms.PictureBox();
            this.salePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wasLabel = new System.Windows.Forms.Label();
            this.oldPriceLabel = new System.Windows.Forms.Label();
            this.curPriceLabel = new System.Windows.Forms.Label();
            this.stockQtyLabel = new System.Windows.Forms.Label();
            this.cartQtySelect = new System.Windows.Forms.ComboBox();
            this.addCartPanel = new System.Windows.Forms.Panel();
            this.addToCartLabel = new System.Windows.Forms.Label();
            this.addToCartImage = new System.Windows.Forms.PictureBox();
            this.removeCartPanel = new System.Windows.Forms.Panel();
            this.removeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).BeginInit();
            this.salePanel.SuspendLayout();
            this.addCartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToCartImage)).BeginInit();
            this.removeCartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // arrows
            // 
            this.arrows.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("arrows.ImageStream")));
            this.arrows.TransparentColor = System.Drawing.Color.Transparent;
            this.arrows.Images.SetKeyName(0, "leftArrow.png");
            this.arrows.Images.SetKeyName(1, "rightArrow.png");
            this.arrows.Images.SetKeyName(2, "leftArrowGray.png");
            this.arrows.Images.SetKeyName(3, "rightArrowGray.png");
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameLabel.Font = new System.Drawing.Font("Futurama Bold Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.ForeColor = System.Drawing.Color.White;
            this.itemNameLabel.Location = new System.Drawing.Point(460, 49);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(303, 103);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "ITEM NAME GO HERE";
            // 
            // itemDescLabel
            // 
            this.itemDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDescLabel.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescLabel.ForeColor = System.Drawing.Color.White;
            this.itemDescLabel.Location = new System.Drawing.Point(462, 152);
            this.itemDescLabel.Name = "itemDescLabel";
            this.itemDescLabel.Size = new System.Drawing.Size(301, 113);
            this.itemDescLabel.TabIndex = 2;
            this.itemDescLabel.Text = "ITEM DESCRIPTION GO HERE";
            // 
            // curImgLabel
            // 
            this.curImgLabel.ForeColor = System.Drawing.Color.White;
            this.curImgLabel.Location = new System.Drawing.Point(199, 271);
            this.curImgLabel.Name = "curImgLabel";
            this.curImgLabel.Size = new System.Drawing.Size(60, 23);
            this.curImgLabel.TabIndex = 19;
            this.curImgLabel.Text = "0/0";
            this.curImgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xButton
            // 
            this.xButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xButton.Image = global::Amazonia_Checkout.Properties.Resources.whiteX;
            this.xButton.InitialImage = global::Amazonia_Checkout.Properties.Resources.whiteX;
            this.xButton.Location = new System.Drawing.Point(740, 12);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(23, 24);
            this.xButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xButton.TabIndex = 22;
            this.xButton.TabStop = false;
            this.xButton.Click += new System.EventHandler(this.CloseItemView);
            // 
            // rightArrow
            // 
            this.rightArrow.BackColor = System.Drawing.Color.Transparent;
            this.rightArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightArrow.Enabled = false;
            this.rightArrow.Image = global::Amazonia_Checkout.Properties.Resources.rightArrowGray;
            this.rightArrow.Location = new System.Drawing.Point(265, 271);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(34, 23);
            this.rightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightArrow.TabIndex = 21;
            this.rightArrow.TabStop = false;
            this.rightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.BackColor = System.Drawing.Color.Transparent;
            this.leftArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftArrow.Enabled = false;
            this.leftArrow.Image = global::Amazonia_Checkout.Properties.Resources.leftArrowGray;
            this.leftArrow.Location = new System.Drawing.Point(159, 271);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(34, 23);
            this.leftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftArrow.TabIndex = 20;
            this.leftArrow.TabStop = false;
            this.leftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // imageView
            // 
            this.imageView.Image = global::Amazonia_Checkout.Properties.Resources.hypnotoad;
            this.imageView.InitialImage = global::Amazonia_Checkout.Properties.Resources.hypnotoad;
            this.imageView.Location = new System.Drawing.Point(12, 12);
            this.imageView.Name = "imageView";
            this.imageView.Size = new System.Drawing.Size(444, 253);
            this.imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageView.TabIndex = 0;
            this.imageView.TabStop = false;
            // 
            // salePanel
            // 
            this.salePanel.Controls.Add(this.wasLabel);
            this.salePanel.Controls.Add(this.oldPriceLabel);
            this.salePanel.Location = new System.Drawing.Point(2, 335);
            this.salePanel.Name = "salePanel";
            this.salePanel.Size = new System.Drawing.Size(163, 18);
            this.salePanel.TabIndex = 23;
            this.salePanel.Visible = false;
            // 
            // wasLabel
            // 
            this.wasLabel.AutoSize = true;
            this.wasLabel.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wasLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wasLabel.Location = new System.Drawing.Point(3, 0);
            this.wasLabel.Name = "wasLabel";
            this.wasLabel.Size = new System.Drawing.Size(52, 19);
            this.wasLabel.TabIndex = 14;
            this.wasLabel.Text = "Was:";
            this.wasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // oldPriceLabel
            // 
            this.oldPriceLabel.AutoSize = true;
            this.oldPriceLabel.Font = new System.Drawing.Font("Futurama Bold Font", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPriceLabel.ForeColor = System.Drawing.Color.Red;
            this.oldPriceLabel.Location = new System.Drawing.Point(61, 0);
            this.oldPriceLabel.Name = "oldPriceLabel";
            this.oldPriceLabel.Size = new System.Drawing.Size(59, 19);
            this.oldPriceLabel.TabIndex = 13;
            this.oldPriceLabel.Text = "$0.00";
            this.oldPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // curPriceLabel
            // 
            this.curPriceLabel.Font = new System.Drawing.Font("Futurama Bold Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curPriceLabel.ForeColor = System.Drawing.Color.White;
            this.curPriceLabel.Location = new System.Drawing.Point(12, 300);
            this.curPriceLabel.Name = "curPriceLabel";
            this.curPriceLabel.Size = new System.Drawing.Size(303, 32);
            this.curPriceLabel.TabIndex = 24;
            this.curPriceLabel.Text = "PRICE HERE";
            this.curPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stockQtyLabel
            // 
            this.stockQtyLabel.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockQtyLabel.ForeColor = System.Drawing.Color.White;
            this.stockQtyLabel.Location = new System.Drawing.Point(12, 365);
            this.stockQtyLabel.Name = "stockQtyLabel";
            this.stockQtyLabel.Size = new System.Drawing.Size(153, 18);
            this.stockQtyLabel.TabIndex = 25;
            this.stockQtyLabel.Text = "STOCK QTY HERE";
            this.stockQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cartQtySelect
            // 
            this.cartQtySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.cartQtySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cartQtySelect.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartQtySelect.ForeColor = System.Drawing.Color.White;
            this.cartQtySelect.FormattingEnabled = true;
            this.cartQtySelect.Location = new System.Drawing.Point(383, 360);
            this.cartQtySelect.Name = "cartQtySelect";
            this.cartQtySelect.Size = new System.Drawing.Size(50, 27);
            this.cartQtySelect.TabIndex = 26;
            this.cartQtySelect.SelectedIndexChanged += new System.EventHandler(this.CartQtyChange);
            // 
            // addCartPanel
            // 
            this.addCartPanel.Controls.Add(this.addToCartLabel);
            this.addCartPanel.Controls.Add(this.addToCartImage);
            this.addCartPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCartPanel.Location = new System.Drawing.Point(211, 358);
            this.addCartPanel.Name = "addCartPanel";
            this.addCartPanel.Size = new System.Drawing.Size(166, 30);
            this.addCartPanel.TabIndex = 27;
            // 
            // addToCartLabel
            // 
            this.addToCartLabel.AutoSize = true;
            this.addToCartLabel.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartLabel.ForeColor = System.Drawing.Color.White;
            this.addToCartLabel.Location = new System.Drawing.Point(52, 7);
            this.addToCartLabel.Name = "addToCartLabel";
            this.addToCartLabel.Size = new System.Drawing.Size(108, 18);
            this.addToCartLabel.TabIndex = 1;
            this.addToCartLabel.Text = "Add to Cart";
            this.addToCartLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateCart);
            // 
            // addToCartImage
            // 
            this.addToCartImage.Image = global::Amazonia_Checkout.Properties.Resources.cart;
            this.addToCartImage.Location = new System.Drawing.Point(3, -2);
            this.addToCartImage.Name = "addToCartImage";
            this.addToCartImage.Size = new System.Drawing.Size(47, 33);
            this.addToCartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addToCartImage.TabIndex = 0;
            this.addToCartImage.TabStop = false;
            // 
            // removeCartPanel
            // 
            this.removeCartPanel.Controls.Add(this.removeLabel);
            this.removeCartPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeCartPanel.Location = new System.Drawing.Point(211, 358);
            this.removeCartPanel.Name = "removeCartPanel";
            this.removeCartPanel.Size = new System.Drawing.Size(166, 30);
            this.removeCartPanel.TabIndex = 21;
            this.removeCartPanel.Visible = false;
            // 
            // removeLabel
            // 
            this.removeLabel.AutoSize = true;
            this.removeLabel.Font = new System.Drawing.Font("Futurama Bold Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLabel.ForeColor = System.Drawing.Color.White;
            this.removeLabel.Location = new System.Drawing.Point(12, 7);
            this.removeLabel.Name = "removeLabel";
            this.removeLabel.Size = new System.Drawing.Size(143, 16);
            this.removeLabel.TabIndex = 0;
            this.removeLabel.Text = "Remove From Cart";
            this.removeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveFromCart);
            // 
            // ItemInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(775, 437);
            this.ControlBox = false;
            this.Controls.Add(this.removeCartPanel);
            this.Controls.Add(this.addCartPanel);
            this.Controls.Add(this.cartQtySelect);
            this.Controls.Add(this.stockQtyLabel);
            this.Controls.Add(this.curPriceLabel);
            this.Controls.Add(this.salePanel);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.curImgLabel);
            this.Controls.Add(this.itemDescLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.imageView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemInfoView";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.xButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).EndInit();
            this.salePanel.ResumeLayout(false);
            this.salePanel.PerformLayout();
            this.addCartPanel.ResumeLayout(false);
            this.addCartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToCartImage)).EndInit();
            this.removeCartPanel.ResumeLayout(false);
            this.removeCartPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList arrows;
        private System.Windows.Forms.PictureBox imageView;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemDescLabel;
        private System.Windows.Forms.PictureBox rightArrow;
        private System.Windows.Forms.PictureBox leftArrow;
        private System.Windows.Forms.Label curImgLabel;
        private System.Windows.Forms.PictureBox xButton;
        private System.Windows.Forms.FlowLayoutPanel salePanel;
        private System.Windows.Forms.Label oldPriceLabel;
        private System.Windows.Forms.Label wasLabel;
        private System.Windows.Forms.Label curPriceLabel;
        private System.Windows.Forms.Label stockQtyLabel;
        private System.Windows.Forms.ComboBox cartQtySelect;
        private System.Windows.Forms.Panel addCartPanel;
        private System.Windows.Forms.Label addToCartLabel;
        private System.Windows.Forms.PictureBox addToCartImage;
        private System.Windows.Forms.Panel removeCartPanel;
        private System.Windows.Forms.Label removeLabel;
    }
}