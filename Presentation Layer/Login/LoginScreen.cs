using BL;
using Presentation_Layer.Global;
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

            User user1 = User.FindUser(txtUsername.Text);

            if (user1 != null)
            {

                if (user1.IsActive == false)
                {
                    MessageBox.Show("User is disabled, contact your admin");
                    return;
                }

                if (user1.IsTheLoginValid(txtPassword.Text))
                {
                MessageBox.Show($"Hello {txtUsername.Text}");
                MainScreen mainScreen = new MainScreen();
                    this.Hide();
                mainScreen.Show();
                }
                //Account MyAcount = new Account(user1);


            }

    
            else
            {
                MessageBox.Show("Incorrect Email Or Password, try again");
               
            }

        }
    }
}


// TODO: Create the validator
// TODO: create account for users 