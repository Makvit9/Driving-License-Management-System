using BL;
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

            //new User(usernameTextBox.Text, passwordTextBox.Text);
            if (User.FindUser(txtUsername.Text, txtPassword.Text) == true)
            {


                //Account MyAcount = new Account(user1);
                MessageBox.Show($"Hello {txtUsername.Text}");
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                
                

            }
            else if (_counter >= 3)
            {
                btnLogin.Enabled = false;
                label1.Visible = true;
            }
            else
            {
                MessageBox.Show("Incorrect Email Or Password, try again");
               
            }

        }
    }
}


// TODO: Create the validator
// TODO: Handle the Hashing 
// TODO: create account for users 