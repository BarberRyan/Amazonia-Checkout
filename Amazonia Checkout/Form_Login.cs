using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationMachine;

namespace Amazonia_Checkout
{
    public partial class Form_Login : Form
    {
        VM_Factory vmf = new VM_Factory();

        public Form_Login()
        {
            InitializeComponent();
            AutoLogin();
            vmf.AddValidator(usernameBox, VM_Type.Min_Length, 1);
            vmf.AddValidator(passwordBox, VM_Type.Max_Length, 1);
        }

        private void AutoLogin()
        {
            (bool, User) loginInfo = SettingsHandler.GetSettings();
            if (loginInfo.Item1)
            {
                RememberMe.Checked = true;
                usernameBox.Enabled = false;
                passwordBox.Enabled = false;
                loginButton.Enabled = false;
                Login(loginInfo.Item2.Name, loginInfo.Item2.PassHash);
            }
        }

        private async Task<(int, string)> CheckLogin(string username, string hash = null)
        {
            string result = "0";
            if(hash == null)
            {
                var response = await API_Interface.CheckLogin(username, passwordBox.Text);
                result = response.Item1;
            }
            else
            {
                result = await API_Interface.CheckLoginPreHash(username, hash);
            }
            if(result == "0")
            {
                return (0, "ERROR");
            }
            else
            {
                return (Int32.Parse(result), hash);
            }
        }


        private void XButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonMouseOver(object sender, EventArgs e)
        {
            loginButton.ImageIndex = 2;
        }

        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            loginButton.ImageIndex = 0;
        }

        private void ButtonMouseDown(object sender, MouseEventArgs e)
        {
            loginButton.ImageIndex = 1;
        }

        private void ButtonMouseUp(object sender, MouseEventArgs e)
        {
            loginButton.ImageIndex = 2;
            Login();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            using (var form = new Form_SignUp())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    usernameBox.Text = form.Username;
                    passwordBox.Select();
                }
            }
        }

        private void PasswordKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private async void Login(string username = null, string hash = null)
        {
            Form_splash splash = new Form_splash();
            splash.Show();
            if(username == null)
            {
                username = usernameBox.Text;
            }
            var response = await CheckLogin(username, hash);
            int userID = response.Item1;
            if (userID == 0)
            {
                splash.Close();
                MessageBox.Show("Invalid username or password.", "ERROR");
            }
            else
            {
                if(hash == null)
                {
                    hash = await API_Interface.GenerateHash((usernameBox.Text,passwordBox.Text));
                }
                MainForm.User = new User(userID, username, hash);
                if (RememberMe.Checked)
                {
                    SettingsHandler.CreateUserSettings();
                }
                else
                {
                    SettingsHandler.RemoveUserSettings();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
