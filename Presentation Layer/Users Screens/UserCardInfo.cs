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
    public partial class UserCardInfo : UserControl
    {


        private User _SelectedUser;

        public UserCardInfo()
        {
            InitializeComponent();
        }


        public void LoadUserInfo(int UserID)
        {
            _SelectedUser = User.FindUser(UserID);
            _FillInfo();


        }

        private void _FillInfo()
        {
            lblUsername.Text = _SelectedUser.Username;
            lblUserID.Text = _SelectedUser.UserID.ToString();


            if (_SelectedUser.IsActive.ToString() == "True")
            {
                lblIsActive.Text = "Active";
            }
            else
            {
                lblIsActive.Text = "Disabled";
            }
            personInfoUpdated1.LoadPersonInfo(_SelectedUser.PersonID);

        }
    }
}
