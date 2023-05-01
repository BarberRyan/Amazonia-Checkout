namespace Amazonia_Checkout
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonImgs = new System.Windows.Forms.ImageList(this.components);
            this.loginButton = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.xButton = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xButton)).BeginInit();
            this.SuspendLayout();
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberMe.ForeColor = System.Drawing.Color.White;
            this.RememberMe.Location = new System.Drawing.Point(19, 273);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(263, 22);
            this.RememberMe.TabIndex = 3;
            this.RememberMe.Text = "Remember me on this device";
            this.RememberMe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(55, 171);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(199, 23);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordKeyDown);
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold);
            this.usernameBox.Location = new System.Drawing.Point(55, 110);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(199, 23);
            this.usernameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futurama Bold Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonImgs
            // 
            this.buttonImgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImgs.ImageStream")));
            this.buttonImgs.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImgs.Images.SetKeyName(0, "buttonUp.png");
            this.buttonImgs.Images.SetKeyName(1, "buttonDown.png");
            this.buttonImgs.Images.SetKeyName(2, "buttonHover.png");
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ImageKey = "buttonUp.png";
            this.loginButton.ImageList = this.buttonImgs;
            this.loginButton.Location = new System.Drawing.Point(74, 204);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(160, 35);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Log In";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
            this.loginButton.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.loginButton.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            this.loginButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Amazonia_Checkout.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(101, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // xButton
            // 
            this.xButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xButton.Image = global::Amazonia_Checkout.Properties.Resources.whiteX;
            this.xButton.InitialImage = global::Amazonia_Checkout.Properties.Resources.whiteX;
            this.xButton.Location = new System.Drawing.Point(258, 12);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(20, 20);
            this.xButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xButton.TabIndex = 1;
            this.xButton.TabStop = false;
            this.xButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Futurama Bold Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(103, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Create Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(294, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.RememberMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.PictureBox xButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList buttonImgs;
        private System.Windows.Forms.Label loginButton;
        private System.Windows.Forms.Label label4;
    }
}