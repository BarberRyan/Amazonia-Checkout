namespace Amazonia_Checkout
{
    partial class Form_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignUp));
            this.signUpButton = new System.Windows.Forms.Label();
            this.buttonImgs = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.xButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.password2FeedbackLabel = new System.Windows.Forms.Label();
            this.password1FeedbackLabel = new System.Windows.Forms.Label();
            this.usernameFeedbackLabel = new System.Windows.Forms.Label();
            this.passwordBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Enabled = false;
            this.signUpButton.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ImageIndex = 0;
            this.signUpButton.ImageList = this.buttonImgs;
            this.signUpButton.Location = new System.Drawing.Point(75, 405);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(160, 35);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Sign Up!";
            this.signUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseDown);
            this.signUpButton.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.signUpButton.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            this.signUpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMouseUp);
            // 
            // buttonImgs
            // 
            this.buttonImgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImgs.ImageStream")));
            this.buttonImgs.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImgs.Images.SetKeyName(0, "buttonUp.png");
            this.buttonImgs.Images.SetKeyName(1, "buttonDown.png");
            this.buttonImgs.Images.SetKeyName(2, "buttonHover.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futurama Bold Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sign Up For";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Amazonia_Checkout.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(57, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // passwordBox1
            // 
            this.passwordBox1.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox1.Location = new System.Drawing.Point(60, 246);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.PasswordChar = '•';
            this.passwordBox1.Size = new System.Drawing.Size(199, 23);
            this.passwordBox1.TabIndex = 1;
            this.passwordBox1.TextChanged += new System.EventHandler(this.RunValidation);
            // 
            // xButton
            // 
            this.xButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xButton.Image = global::Amazonia_Checkout.Properties.Resources.whiteX;
            this.xButton.InitialImage = global::Amazonia_Checkout.Properties.Resources.whiteX;
            this.xButton.Location = new System.Drawing.Point(289, 9);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(20, 20);
            this.xButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xButton.TabIndex = 10;
            this.xButton.TabStop = false;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.password2FeedbackLabel);
            this.panel1.Controls.Add(this.password1FeedbackLabel);
            this.panel1.Controls.Add(this.usernameFeedbackLabel);
            this.panel1.Controls.Add(this.passwordBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signUpButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.passwordBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.xButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 450);
            this.panel1.TabIndex = 16;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(60, 149);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(199, 23);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TextChanged += new System.EventHandler(this.RunValidation);
            // 
            // password2FeedbackLabel
            // 
            this.password2FeedbackLabel.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2FeedbackLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.password2FeedbackLabel.Location = new System.Drawing.Point(60, 367);
            this.password2FeedbackLabel.Name = "password2FeedbackLabel";
            this.password2FeedbackLabel.Size = new System.Drawing.Size(198, 33);
            this.password2FeedbackLabel.TabIndex = 20;
            this.password2FeedbackLabel.Text = "Passwords must match!";
            this.password2FeedbackLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.password2FeedbackLabel.Visible = false;
            // 
            // password1FeedbackLabel
            // 
            this.password1FeedbackLabel.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1FeedbackLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.password1FeedbackLabel.Location = new System.Drawing.Point(60, 274);
            this.password1FeedbackLabel.Name = "password1FeedbackLabel";
            this.password1FeedbackLabel.Size = new System.Drawing.Size(198, 33);
            this.password1FeedbackLabel.TabIndex = 19;
            this.password1FeedbackLabel.Text = "Password must be at least 8 characters long!";
            this.password1FeedbackLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.password1FeedbackLabel.Visible = false;
            // 
            // usernameFeedbackLabel
            // 
            this.usernameFeedbackLabel.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameFeedbackLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.usernameFeedbackLabel.Location = new System.Drawing.Point(60, 182);
            this.usernameFeedbackLabel.Name = "usernameFeedbackLabel";
            this.usernameFeedbackLabel.Size = new System.Drawing.Size(198, 33);
            this.usernameFeedbackLabel.TabIndex = 18;
            this.usernameFeedbackLabel.Text = "Username must be at least 8 characters long!";
            this.usernameFeedbackLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.usernameFeedbackLabel.Visible = false;
            // 
            // passwordBox2
            // 
            this.passwordBox2.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox2.Location = new System.Drawing.Point(60, 341);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.PasswordChar = '•';
            this.passwordBox2.Size = new System.Drawing.Size(199, 23);
            this.passwordBox2.TabIndex = 2;
            this.passwordBox2.TextChanged += new System.EventHandler(this.RunValidation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futurama Bold Font", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SignUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label signUpButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.PictureBox xButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList buttonImgs;
        private System.Windows.Forms.Label password2FeedbackLabel;
        private System.Windows.Forms.Label password1FeedbackLabel;
        private System.Windows.Forms.Label usernameFeedbackLabel;
        private System.Windows.Forms.TextBox passwordBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameBox;
    }
}