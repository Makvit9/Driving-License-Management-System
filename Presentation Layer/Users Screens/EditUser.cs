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
    public partial class EditUser : Form
    {
        User CurrentUser;
        public EditUser(int UserID)
        {
            InitializeComponent();



            CurrentUser = User.FindUser(UserID);


            txtPersonID.Text = CurrentUser.PersonID.ToString();
            txtUsername.Text = CurrentUser.Username;
            
            if (CurrentUser.IsActive)
            {
                chkIsActive.Checked = true;
                chkIsActive.Text = "User account is Active";
            }
            else
            {
                chkIsActive.Checked = false;
                chkIsActive.Text = "User account is disabled";
            }


            personInfoCard1.LoadPersonInfo(CurrentUser.PersonID);

        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsActive.Checked)
            {
                
                chkIsActive.Text = "User account is Active";
            }
            else
            {
                
                chkIsActive.Text = "User account is disabled";
            }
        }


        private void prepareUser(User currentUser)
        {
            currentUser.PersonID = Int32.Parse(txtPersonID.Text);
            currentUser.Username = txtUsername.Text;
            currentUser.IsActive = chkIsActive.Checked ? true :  false;
            currentUser.Mode = User.enmode.Update;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            prepareUser(CurrentUser);
            if (CurrentUser.Save())
                MessageBox.Show("User was Updated successfully");
        }
    }
}
