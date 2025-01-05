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
    public partial class UserCard : UserControl
    {
        public UserCard()
        {
            InitializeComponent();
            
        }

        public string Username
        {
            get
            {
                return lblUsername.Text;
            }
            set
            {
                lblUsername.Text = value;
            }
        }
        public string IsActive 
        {
            get
            {
                return lblActiveStatus.Text;
            }
            set
            {
                if (value == "True")

                {
                    lblActiveStatus.Text = "Active";
                }
                else
                {
                    lblActiveStatus.Text = "Disabled";
                }
            }
        }

    }
}
