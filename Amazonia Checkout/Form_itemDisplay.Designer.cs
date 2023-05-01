namespace Amazonia_Checkout
{
    partial class Form_itemDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_itemDisplay));
            this.itemImages = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeCartPanel = new System.Windows.Forms.Panel();
            this.removeLabel = new System.Windows.Forms.Label();
            this.addCartPanel = new System.Windows.Forms.Panel();
            this.addToCartLabel = new System.Windows.Forms.Label();
            this.addToCartImage = new System.Windows.Forms.PictureBox();
            this.rightArrow = new System.Windows.Forms.PictureBox();
            this.leftArrow = new System.Windows.Forms.PictureBox();
            this.salePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.oldPriceLabel = new System.Windows.Forms.Label();
            this.wasLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.curPriceLabel = new System.Windows.Forms.Label();
            this.curImgLabel = new System.Windows.Forms.Label();
            this.imageView = new System.Windows.Forms.PictureBox();
            this.arrows = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.removeCartPanel.SuspendLayout();
            this.addCartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToCartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).BeginInit();
            this.salePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemImages
            // 
            this.itemImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.itemImages.ImageSize = new System.Drawing.Size(164, 105);
            this.itemImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeCartPanel);
            this.groupBox1.Controls.Add(this.addCartPanel);
            this.groupBox1.Controls.Add(this.rightArrow);
            this.groupBox1.Controls.Add(this.leftArrow);
            this.groupBox1.Controls.Add(this.salePanel);
            this.groupBox1.Controls.Add(this.itemNameLabel);
            this.groupBox1.Controls.Add(this.curPriceLabel);
            this.groupBox1.Controls.Add(this.curImgLabel);
            this.groupBox1.Controls.Add(this.imageView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // removeCartPanel
            // 
            this.removeCartPanel.Controls.Add(this.removeLabel);
            this.removeCartPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeCartPanel.Location = new System.Drawing.Point(10, 265);
            this.removeCartPanel.Name = "removeCartPanel";
            this.removeCartPanel.Size = new System.Drawing.Size(166, 30);
            this.removeCartPanel.TabIndex = 20;
            this.removeCartPanel.Visible = false;
            this.removeCartPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveFromCart);
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
            // addCartPanel
            // 
            this.addCartPanel.Controls.Add(this.addToCartLabel);
            this.addCartPanel.Controls.Add(this.addToCartImage);
            this.addCartPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCartPanel.Location = new System.Drawing.Point(10, 267);
            this.addCartPanel.Name = "addCartPanel";
            this.addCartPanel.Size = new System.Drawing.Size(166, 30);
            this.addCartPanel.TabIndex = 19;
            this.addCartPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddToCart);
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
            this.addToCartLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddToCart);
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
            this.addToCartImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddToCart);
            // 
            // rightArrow
            // 
            this.rightArrow.BackColor = System.Drawing.Color.Transparent;
            this.rightArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightArrow.Enabled = false;
            this.rightArrow.Image = global::Amazonia_Checkout.Properties.Resources.rightArrowGray;
            this.rightArrow.Location = new System.Drawing.Point(130, 134);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(34, 23);
            this.rightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightArrow.TabIndex = 18;
            this.rightArrow.TabStop = false;
            this.rightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.BackColor = System.Drawing.Color.Transparent;
            this.leftArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftArrow.Enabled = false;
            this.leftArrow.Image = global::Amazonia_Checkout.Properties.Resources.leftArrowGray;
            this.leftArrow.Location = new System.Drawing.Point(24, 134);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(34, 23);
            this.leftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftArrow.TabIndex = 17;
            this.leftArrow.TabStop = false;
            this.leftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // salePanel
            // 
            this.salePanel.Controls.Add(this.oldPriceLabel);
            this.salePanel.Controls.Add(this.wasLabel);
            this.salePanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.salePanel.Location = new System.Drawing.Point(19, 248);
            this.salePanel.Name = "salePanel";
            this.salePanel.Size = new System.Drawing.Size(163, 16);
            this.salePanel.TabIndex = 16;
            this.salePanel.Visible = false;
            // 
            // oldPriceLabel
            // 
            this.oldPriceLabel.AutoSize = true;
            this.oldPriceLabel.Font = new System.Drawing.Font("Futurama Bold Font", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPriceLabel.ForeColor = System.Drawing.Color.Red;
            this.oldPriceLabel.Location = new System.Drawing.Point(112, 0);
            this.oldPriceLabel.Name = "oldPriceLabel";
            this.oldPriceLabel.Size = new System.Drawing.Size(48, 16);
            this.oldPriceLabel.TabIndex = 13;
            this.oldPriceLabel.Text = "$0.00";
            this.oldPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wasLabel
            // 
            this.wasLabel.Font = new System.Drawing.Font("Futurama Bold Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wasLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.wasLabel.Location = new System.Drawing.Point(63, 0);
            this.wasLabel.Name = "wasLabel";
            this.wasLabel.Size = new System.Drawing.Size(43, 16);
            this.wasLabel.TabIndex = 14;
            this.wasLabel.Text = "Was:";
            this.wasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.ForeColor = System.Drawing.Color.White;
            this.itemNameLabel.Location = new System.Drawing.Point(12, 171);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(164, 38);
            this.itemNameLabel.TabIndex = 15;
            this.itemNameLabel.Text = "NAME GO HERE";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.itemNameLabel.Click += new System.EventHandler(this.OpenInfoView);
            // 
            // curPriceLabel
            // 
            this.curPriceLabel.Font = new System.Drawing.Font("Futurama Bold Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curPriceLabel.ForeColor = System.Drawing.Color.White;
            this.curPriceLabel.Location = new System.Drawing.Point(19, 220);
            this.curPriceLabel.Name = "curPriceLabel";
            this.curPriceLabel.Size = new System.Drawing.Size(160, 25);
            this.curPriceLabel.TabIndex = 12;
            this.curPriceLabel.Text = "$0.00";
            this.curPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curImgLabel
            // 
            this.curImgLabel.ForeColor = System.Drawing.Color.White;
            this.curImgLabel.Location = new System.Drawing.Point(64, 134);
            this.curImgLabel.Name = "curImgLabel";
            this.curImgLabel.Size = new System.Drawing.Size(60, 23);
            this.curImgLabel.TabIndex = 11;
            this.curImgLabel.Text = "0/0";
            this.curImgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageView
            // 
            this.imageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageView.Image = global::Amazonia_Checkout.Properties.Resources.hypnotoad;
            this.imageView.InitialImage = null;
            this.imageView.Location = new System.Drawing.Point(12, 19);
            this.imageView.Name = "imageView";
            this.imageView.Size = new System.Drawing.Size(164, 105);
            this.imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageView.TabIndex = 8;
            this.imageView.TabStop = false;
            this.imageView.Click += new System.EventHandler(this.OpenInfoView);
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
            // Form_itemDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(188, 300);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_itemDisplay";
            this.groupBox1.ResumeLayout(false);
            this.removeCartPanel.ResumeLayout(false);
            this.removeCartPanel.PerformLayout();
            this.addCartPanel.ResumeLayout(false);
            this.addCartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToCartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).EndInit();
            this.salePanel.ResumeLayout(false);
            this.salePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList itemImages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label wasLabel;
        private System.Windows.Forms.Label oldPriceLabel;
        private System.Windows.Forms.Label curPriceLabel;
        private System.Windows.Forms.Label curImgLabel;
        private System.Windows.Forms.PictureBox imageView;
        private System.Windows.Forms.FlowLayoutPanel salePanel;
        private System.Windows.Forms.PictureBox rightArrow;
        private System.Windows.Forms.PictureBox leftArrow;
        private System.Windows.Forms.ImageList arrows;
        private System.Windows.Forms.Panel addCartPanel;
        private System.Windows.Forms.Label addToCartLabel;
        private System.Windows.Forms.PictureBox addToCartImage;
        private System.Windows.Forms.Panel removeCartPanel;
        private System.Windows.Forms.Label removeLabel;
    }
}