﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Users_Screens
{
    public partial class AccountSettings : Form
    {

        User _CurrentUser;
        int _UserID;
        public AccountSettings(int userID)
        {
            InitializeComponent();

            _UserID = userID;

        }

        private void ResetValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}
