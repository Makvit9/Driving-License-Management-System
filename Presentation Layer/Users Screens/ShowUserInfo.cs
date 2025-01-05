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

        private User user1;

        public ShowUserInfo(int UserID)
        {
            InitializeComponent();
            user1 = User.FindUser(UserID);

            _FillInfo();

        
        }

        private void _FillInfo()
        {
            lblUsername.Text = user1.Username;
            lblUserID.Text = user1.UserID.ToString();


            if (user1.IsActive.ToString() == "True")
            {
                lblIsActive.Text = "Active";
            }
            else
            {
                lblIsActive.Text = "Disabled";
            }
            personInfoCard1.PersonInfo(user1.PersonID);
            
        }
    }
}
