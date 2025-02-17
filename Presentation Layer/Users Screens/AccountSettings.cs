using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;
using Presentation_Layer.People_Screens.Validators;

namespace Presentation_Layer.Users_Screens
{
    public partial class AccountSettings : Form
    {

        private User _CurrentUser;
        private int _UserID;
        public AccountSettings(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _CurrentUser = User.FindUser(UserID);
            userCardInfo1.LoadUserInfo(_UserID);

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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (Validators.IsTheCellEmpty(txtCurrentPassword.Text))
            {
                ErrorProvider error = new ErrorProvider();
                error.SetError(txtCurrentPassword, "This Can't be empty!! ");
            }



        }
    }
}
