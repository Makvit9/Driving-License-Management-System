using BL;
using Presentation_Layer.People_Screens.Validators;
using Syncfusion.Windows.Forms.Interop;
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
    public partial class AddNewUserUpdated : Form
    {
        private User _SelectedUser = new User();
        public AddNewUserUpdated()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (personInfoWithFIlter1.PersonID != -1)
            {

                if (User.IsPersonLinkedToOtherUser(personInfoWithFIlter1.PersonID))
                {
                    MessageBox.Show("This person is already linked with a user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    personInfoWithFIlter1.Focus();
                    tpLoginInfo.Enabled = false;

                }
                else
                {
                    _SelectedUser.PersonID = personInfoWithFIlter1.PersonID;
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcNewUser.SelectedTab = tcNewUser.TabPages["tpLoginInfo"];

                }


            }

        }

        private void AddNewUserUpdated_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            //tpLoginInfo.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrepareUser(User currentUser)
        {
            
            currentUser.Username = txtUsername.Text;
            currentUser.Password = txtPassword.Text;
            /*currentUser.HashPassword()        Coming Soon*/
            currentUser.IsActive = chkIsActive.Checked ? true : false;
            currentUser.Mode = User.enmode.AddNew;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validators.AreTheStringsMatched(txtPassword.Text, txtConfirmPassword.Text))
            {
                MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrepareUser(_SelectedUser);
            if (_SelectedUser.Save())
                {
                MessageBox.Show("User was added successfully", "User was Added", MessageBoxButtons.OK);
                }

           
        }
    }
}
