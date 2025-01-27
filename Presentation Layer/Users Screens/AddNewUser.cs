using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Syncfusion.Windows.Forms;
namespace Presentation_Layer.Users_Screens
{
    public partial class AddNewUser : Form
    {

        private User _User;
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void _IsUsernameExists(object sender, CancelEventArgs e)
        {
            if (User.IsTheUsernameExists(((TextBox)sender).Text))
            {
                e.Cancel = true;
                errUniqueUsername.SetError((TextBox)sender, "Username Should be unique");
            }

        }

        private void _ClearError(object sender, EventArgs e)
        {
            errUniqueUsername.Clear();
        }

        private void _IsPersonLinkedToOtherUser(object sender, CancelEventArgs e)
        {
            if (User.IsPersonLinkedToOtherUser(Int32.Parse(((TextBox)sender).Text)))
            {
                e.Cancel = true;
                errUniqueUsername.SetError((TextBox)sender, "This Person Is linked to another user");
            }

        }

        private void prepareUser(User currentUser)
        {
            currentUser.PersonID = Int32.Parse(txtPersonID.Text);
            currentUser.Username = txtUsername.Text;


            currentUser.Password = txtPassword.Text; //This is only for now 
            /*currentUser.HashPassword()        Coming Soon*/
            currentUser.IsActive = chkIsActive.Checked ? true : false;
            currentUser.Mode = User.enmode.AddNew;

        }

        private void _CreateUserAccount(object sender, EventArgs e)
        {
            prepareUser(_User);
            //_User = new User(Int32.Parse(txtPersonID.Text), txtUsername.Text, txtPassword.Text, chkIsActive.Checked);
            if (_User.Save())
            {
                MessageBox.Show($"User with ID {_User.UserID} was created successfully");
                this.Close();
            }
        }
    }
}
