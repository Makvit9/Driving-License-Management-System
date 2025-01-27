using BL;
using System;
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
    public partial class ChangeUserPassword : Form
    {
        private int userID { get; }
        public ChangeUserPassword()
        {
            InitializeComponent();
        }

        public ChangeUserPassword(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            userCardInfo1.LoadUserInfo(userID);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text /* TODO:  Extract to single method   || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmNewPassword.Text)*/)
            {
                MessageBox.Show("Make sure that the password match!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
               if (User.UpdatePassword(userID, txtNewPassword.Text))
                {
                    MessageBox.Show("Password Was reset successfully!");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
