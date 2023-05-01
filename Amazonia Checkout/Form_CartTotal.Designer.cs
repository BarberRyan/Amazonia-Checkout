namespace Amazonia_Checkout
{
    partial class CartTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartTotal));
            this.totalItemsLabel = new System.Windows.Forms.Label();
            this.buttons = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalItemsLabel
            // 
            this.totalItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalItemsLabel.AutoSize = true;
            this.totalItemsLabel.Font = new System.Drawing.Font("Futurama Bold Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsLabel.ForeColor = System.Drawing.Color.Silver;
            this.totalItemsLabel.Location = new System.Drawing.Point(576, 14);
            this.totalItemsLabel.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.totalItemsLabel.Name = "totalItemsLabel";
            this.totalItemsLabel.Size = new System.Drawing.Size(97, 16);
            this.totalItemsLabel.TabIndex = 0;
            this.totalItemsLabel.Text = "(#### items)";
            this.totalItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttons
            // 
            this.buttons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttons.ImageStream")));
            this.buttons.TransparentColor = System.Drawing.Color.Transparent;
            this.buttons.Images.SetKeyName(0, "buttonUp.png");
            this.buttons.Images.SetKeyName(1, "buttonDown.png");
            this.buttons.Images.SetKeyName(2, "buttonHover.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkoutButton);
            this.flowLayoutPanel1.Controls.Add(this.totalItemsLabel);
            this.flowLayoutPanel1.Controls.Add(this.totalPriceLabel);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(791, 49);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.ImageIndex = 0;
            this.checkoutButton.ImageList = this.buttons;
            this.checkoutButton.Location = new System.Drawing.Point(676, 3);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(112, 36);
            this.checkoutButton.TabIndex = 1;
            this.checkoutButton.Text = "Check out";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            this.checkoutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkoutButton_MouseDown);
            this.checkoutButton.MouseEnter += new System.EventHandler(this.checkoutButton_MouseEnter);
            this.checkoutButton.MouseLeave += new System.EventHandler(this.checkoutButton_MouseLeave);
            this.checkoutButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkoutButton_MouseUp);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(490, 14);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(86, 19);
            this.totalPriceLabel.TabIndex = 3;
            this.totalPriceLabel.Text = "$###.##";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(804, 63);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "CartTotal";
            this.ShowIcon = false;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label totalItemsLabel;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.ImageList buttons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label1;
    }
}