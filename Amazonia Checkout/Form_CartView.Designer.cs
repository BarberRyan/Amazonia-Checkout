namespace Amazonia_Checkout
{
    partial class CartView
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
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.cartQtySelect = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.xButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xButton)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.ForeColor = System.Drawing.Color.White;
            this.itemNameLabel.Location = new System.Drawing.Point(115, 6);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(188, 60);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Farnsworth Novelty Disitegrator Ray";
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cartQtySelect
            // 
            this.cartQtySelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cartQtySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.cartQtySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cartQtySelect.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartQtySelect.ForeColor = System.Drawing.Color.White;
            this.cartQtySelect.FormattingEnabled = true;
            this.cartQtySelect.Location = new System.Drawing.Point(576, 24);
            this.cartQtySelect.Name = "cartQtySelect";
            this.cartQtySelect.Size = new System.Drawing.Size(50, 27);
            this.cartQtySelect.TabIndex = 27;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.White;
            this.quantityLabel.Location = new System.Drawing.Point(415, 28);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(155, 19);
            this.quantityLabel.TabIndex = 2;
            this.quantityLabel.Text = "Quantity in cart: ";
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.White;
            this.priceLabel.Location = new System.Drawing.Point(631, 28);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(149, 19);
            this.priceLabel.TabIndex = 28;
            this.priceLabel.Text = "PRICE HERE";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imageBox
            // 
            this.imageBox.Image = global::Amazonia_Checkout.Properties.Resources.hypnotoad;
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(100, 50);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // xButton
            // 
            this.xButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xButton.Image = global::Amazonia_Checkout.Properties.Resources.whiteX;
            this.xButton.Location = new System.Drawing.Point(786, 12);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(18, 18);
            this.xButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.xButton.TabIndex = 3;
            this.xButton.TabStop = false;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // CartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(804, 63);
            this.ControlBox = false;
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.cartQtySelect);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.xButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "CartView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.PictureBox xButton;
        private System.Windows.Forms.ComboBox cartQtySelect;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}