namespace Amazonia_Checkout
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cartQtyLabel = new System.Windows.Forms.Label();
            this.itemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemInfoPanel = new System.Windows.Forms.Panel();
            this.profile = new System.Windows.Forms.PictureBox();
            this.shoppingCart = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.logoutPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.logoutDDTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsDDTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.disableAutoLoginButton = new System.Windows.Forms.Button();
            this.cartPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.logoutPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartQtyLabel
            // 
            this.cartQtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cartQtyLabel.AutoSize = true;
            this.cartQtyLabel.BackColor = System.Drawing.Color.SpringGreen;
            this.cartQtyLabel.Location = new System.Drawing.Point(640, 51);
            this.cartQtyLabel.Name = "cartQtyLabel";
            this.cartQtyLabel.Size = new System.Drawing.Size(13, 13);
            this.cartQtyLabel.TabIndex = 4;
            this.cartQtyLabel.Text = "0";
            this.cartQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cartQtyLabel.Visible = false;
            // 
            // itemPanel
            // 
            this.itemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemPanel.AutoScroll = true;
            this.itemPanel.Location = new System.Drawing.Point(12, 71);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(776, 367);
            this.itemPanel.TabIndex = 5;
            // 
            // itemInfoPanel
            // 
            this.itemInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemInfoPanel.Location = new System.Drawing.Point(12, 71);
            this.itemInfoPanel.Name = "itemInfoPanel";
            this.itemInfoPanel.Size = new System.Drawing.Size(775, 367);
            this.itemInfoPanel.TabIndex = 6;
            this.itemInfoPanel.Visible = false;
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile.Image = global::Amazonia_Checkout.Properties.Resources.userSettings;
            this.profile.Location = new System.Drawing.Point(670, 13);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(56, 52);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 7;
            this.profile.TabStop = false;
            this.toolTip.SetToolTip(this.profile, "Profile");
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // shoppingCart
            // 
            this.shoppingCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shoppingCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shoppingCart.Image = ((System.Drawing.Image)(resources.GetObject("shoppingCart.Image")));
            this.shoppingCart.Location = new System.Drawing.Point(608, 12);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(56, 52);
            this.shoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shoppingCart.TabIndex = 3;
            this.shoppingCart.TabStop = false;
            this.toolTip.SetToolTip(this.shoppingCart, "Shopping Cart");
            this.shoppingCart.Click += new System.EventHandler(this.ShoppingCart_Click);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(732, 13);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(56, 52);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 2;
            this.settings.TabStop = false;
            this.toolTip.SetToolTip(this.settings, "Settings");
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 13);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(167, 52);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // logoutPanel
            // 
            this.logoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoutPanel.Controls.Add(this.logoutButton);
            this.logoutPanel.Location = new System.Drawing.Point(589, 67);
            this.logoutPanel.MaximumSize = new System.Drawing.Size(137, 25);
            this.logoutPanel.Name = "logoutPanel";
            this.logoutPanel.Size = new System.Drawing.Size(137, 1);
            this.logoutPanel.TabIndex = 8;
            this.logoutPanel.Visible = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Futurama Bold Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(0, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(135, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // logoutDDTimer
            // 
            this.logoutDDTimer.Interval = 5;
            this.logoutDDTimer.Tick += new System.EventHandler(this.LogoutDDTimer_Tick);
            // 
            // settingsDDTimer
            // 
            this.settingsDDTimer.Interval = 5;
            this.settingsDDTimer.Tick += new System.EventHandler(this.SettingsDDTimer_Tick);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.disableAutoLoginButton);
            this.settingsPanel.Location = new System.Drawing.Point(651, 67);
            this.settingsPanel.MaximumSize = new System.Drawing.Size(137, 25);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(137, 1);
            this.settingsPanel.TabIndex = 9;
            this.settingsPanel.Visible = false;
            // 
            // disableAutoLoginButton
            // 
            this.disableAutoLoginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.disableAutoLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disableAutoLoginButton.Font = new System.Drawing.Font("Futurama Bold Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableAutoLoginButton.ForeColor = System.Drawing.Color.White;
            this.disableAutoLoginButton.Location = new System.Drawing.Point(0, 0);
            this.disableAutoLoginButton.Name = "disableAutoLoginButton";
            this.disableAutoLoginButton.Size = new System.Drawing.Size(135, 23);
            this.disableAutoLoginButton.TabIndex = 0;
            this.disableAutoLoginButton.Text = "Disable auto-login";
            this.disableAutoLoginButton.UseVisualStyleBackColor = true;
            this.disableAutoLoginButton.Click += new System.EventHandler(this.DAL_Button_Click);
            // 
            // cartPanel
            // 
            this.cartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartPanel.AutoScroll = true;
            this.cartPanel.Location = new System.Drawing.Point(12, 71);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(775, 367);
            this.cartPanel.TabIndex = 10;
            this.cartPanel.Visible = false;
            this.cartPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.CartControlsChanged);
            this.cartPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.CartControlsChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.logoutPanel);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.itemInfoPanel);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.cartQtyLabel);
            this.Controls.Add(this.shoppingCart);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.cartPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazonia Checkout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.logoutPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.PictureBox shoppingCart;
        private System.Windows.Forms.Label cartQtyLabel;
        public System.Windows.Forms.FlowLayoutPanel itemPanel;
        private System.Windows.Forms.Panel itemInfoPanel;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel logoutPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Timer logoutDDTimer;
        private System.Windows.Forms.Timer settingsDDTimer;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button disableAutoLoginButton;
        public System.Windows.Forms.FlowLayoutPanel cartPanel;
    }
}

