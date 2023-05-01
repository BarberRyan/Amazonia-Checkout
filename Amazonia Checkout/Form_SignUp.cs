using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationMachine;

namespace Amazonia_Checkout
{
    public partial class Form_SignUp : Form
    {
        public string Username { get; set; }

        VM_Factory vmf = new VM_Factory();
        bool UsernameStatus = true;
        public Form_SignUp()
        {
            InitializeComponent();
            AddValidation();
        }

        private void AddValidation()
        {

            Func<bool> unStatus = delegate () { return UsernameStatus; };
            vmf.AddValidator(usernameBox, VM_Type.Func, unStatus);
            vmf.AddFeedback(usernameBox, VM_Status.Func_Fail, () =>
            {
                usernameFeedbackLabel.Text = "Username is not available";
                usernameFeedbackLabel.Visible = true;
            });

            //Username minimum length
            vmf.AddValidator(usernameBox, VM_Type.Min_Length, 6);
            vmf.AddFeedback(usernameBox, VM_Status.Too_Short, () =>
            {
                usernameFeedbackLabel.Text = "Username must be at least 6 characters long";
                usernameFeedbackLabel.Visible = true;
            });

            //Hide feedback label when ok
            vmf.AddFeedback(usernameBox, VM_Status.OK, () =>
            {
                usernameFeedbackLabel.Visible = false;
            });

            //Password 1 minimum length
            vmf.AddValidator(passwordBox1, VM_Type.Min_Length, 8);
            vmf.AddFeedback(passwordBox1, VM_Status.Too_Short, () =>
            {
                password1FeedbackLabel.Text = "Password must be at least 8 characters long";
                password1FeedbackLabel.Visible = true;
            });

            //Password 1 special character
            vmf.AddValidator(passwordBox1, VM_Type.Spec_Char);
            vmf.AddFeedback(passwordBox1, VM_Status.No_Spec_Char, () =>
            {
                password1FeedbackLabel.Text = "Password must contain at least 1 special character";
                password1FeedbackLabel.Visible = true;
            });

            //Password 1 capital letter
            vmf.AddValidator(passwordBox1, VM_Type.Capital);
            vmf.AddFeedback(passwordBox1, VM_Status.No_Capital, () =>
            {
                password1FeedbackLabel.Text = "Password must contain at least 1 capital letter";
                password1FeedbackLabel.Visible = true;
            });

            //Hide feedback label when ok
            vmf.AddFeedback(passwordBox1, VM_Status.OK, () =>
            {
                password1FeedbackLabel.Visible = false;
            });

            //Password 2 matches password 1
            vmf.AddValidator(passwordBox2, VM_Type.Equal_Control, passwordBox1);
            vmf.AddFeedback(passwordBox2, VM_Status.Not_Equal_Control, () =>
            {
                password2FeedbackLabel.Text = "Passwords must match!";
                password2FeedbackLabel.Visible = true;
            });

            //Hide feedback label when ok
            vmf.AddFeedback(passwordBox2, VM_Status.OK, () =>
            {
                password2FeedbackLabel.Visible = false;
            });
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonMouseOver(object sender, EventArgs e)
        {
            signUpButton.ImageIndex = 2;
        }

        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            signUpButton.ImageIndex = 0;
        }

        private void ButtonMouseDown(object sender, MouseEventArgs e)
        {
            signUpButton.ImageIndex = 1;
        }

        private async void ButtonMouseUp(object sender, MouseEventArgs e)
        {
            signUpButton.ImageIndex = 2;
            if (Validate(usernameBox))
            {
                var response = await API_Interface.AddUser(usernameBox.Text, passwordBox1.Text);
                if (response)
                {
                    MessageBox.Show($"Successfully created user {usernameBox.Text}!", "Success!", MessageBoxButtons.OK);
                    Username = usernameBox.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show($"Failed to create user {usernameBox.Text}!", "Failure!", MessageBoxButtons.OK);
                }
            }
            
        }

        private void RunValidation(object sender, EventArgs e)
        {
            Validate((Control)sender);
            if (sender.Equals(usernameBox))
            {
                CheckUsername();
            }
        }

        private bool Validate(Control control)
        {
            vmf.Validate(control);

            List<(Control, List<VM_Status>)> vList = vmf.ValidateAll(false);

            bool valid = true;

            foreach (var entry in vList)
            {
                if (entry.Item2[0] != VM_Status.OK)
                {
                    valid = false;
                }
            }

            if (valid)
            {
                signUpButton.Enabled = true;
            }
            else
            {
                signUpButton.Enabled = false;
            }
            return valid;
        }

        private async void CheckUsername()
        {
            var status = await API_Interface.CheckUsername(usernameBox.Text);

            if(status == "0")
            {
                UsernameStatus = true;
            }
            else
            {
                UsernameStatus = false;
            }

            Validate(usernameBox);
        }
    }
}
