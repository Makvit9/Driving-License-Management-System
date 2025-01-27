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
namespace Presentation_Layer.Users_Screens
{
    public partial class ShowUserInfo : Form
    {
        public ShowUserInfo()
        {
            InitializeComponent();
        }

        private User _SelectedUser;

        public ShowUserInfo(int UserID)
        {
            InitializeComponent();
            _SelectedUser = User.FindUser(UserID);
            userCardInfo1.LoadUserInfo(UserID);
            //_FillInfo();

        
        }

        //private void _FillInfo()
        //{
        //    lblUsername.Text = _SelectedUser.Username;
        //    lblUserID.Text = _SelectedUser.UserID.ToString();


        //    if (_SelectedUser.IsActive.ToString() == "True")
        //    {
        //        lblIsActive.Text = "Active";
        //    }
        //    else
        //    {
        //        lblIsActive.Text = "Disabled";
        //    }
        //    personInfoUpdated1.LoadPersonInfo(_SelectedUser.PersonID);
            
        //}
    }
}
