﻿using BL;
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



            //new User(usernameTextBox.Text, passwordTextBox.Text);

            User user1 = User.FindUser(txtUsername.Text);

            if (user1 != null)
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
                        
                        Global.SavingUsername.SaveUsername(txtUsername.Text);
                    }

                    MessageBox.Show($"Hello {txtUsername.Text}");
                    

                MainScreen mainScreen = new MainScreen();
                    this.Hide();
                mainScreen.Show();
                }
                else if (_counter < 3)
                {
                    MessageBox.Show("Incorrect Email Or Password, try again");
                    
                }
                else
                {
                    btnLogin.Enabled = false;
                    MessageBox.Show("You are locked Out! Contact your admin");
                }
                //Account MyAcount = new Account(user1);


            }

    
            else
            {
                MessageBox.Show("Please enter a valid Username");
               
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