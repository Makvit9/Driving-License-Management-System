using BL;
using Presentation_Layer.Global;
using Presentation_Layer.People_Screens.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentation_Layer
{
    public partial class LoginScreen : Form
    {


        private int _counter = 0;
    
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _counter++;


            User user1 = User.FindUser(txtUsername.Text);

            if (user1 != null && _counter < 3)
            {

                if (user1.IsActive == false )
                {
                    MessageBox.Show("User is disabled, contact your admin");
                    return;
                }

                if (user1.IsTheLoginValid(txtPassword.Text))
                {


                    if (cbRememberUsername.Checked == true)
                    {
                        
                        Global.CurrentUser.SaveUsername(txtUsername.Text);
                    }

                    MessageBox.Show($"Hello {txtUsername.Text}");
                    Global.CurrentUser.LoggedInUser = user1;

                MainScreen mainScreen = new MainScreen();
                    this.Hide();
                mainScreen.Show();
                }
                else 
                {
                    MessageBox.Show("Incorrect Email Or Password, try again");
                    
                }
               
                //Account MyAcount = new Account(user1);


            }

            else
            {
                MessageBox.Show("Username doesn't exist, please make sure that the user is correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_counter >= 3)
            {
                btnLogin.Enabled = false;
                MessageBox.Show("You are locked Out! Contact your admin");
            }

        }

        private void Validated(object sender, EventArgs e)
        {
            errEmpty.Clear();
            btnLogin.Enabled = true;
        }

        private void Validating(object sender, CancelEventArgs e)
        {
            if (Validators.IsTheCellEmpty(((TextBox)sender).Text))
            {
                e.Cancel = true;
                errEmpty.SetError((TextBox)sender, "This Can't be empty!!");
                btnLogin.Enabled = false;
            }
        }
    }
}


// TODO: Create the validator
// TODO: create account for users 