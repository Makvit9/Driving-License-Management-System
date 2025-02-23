using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Presentation_Layer.Applications
{
    public partial class LocalApplicationInfo: UserControl
    {
        LocalDrivingLicenseApplication _SelectedApplication;
        
        private int _LocalDrivingLicenseApplicationID = -1;

        public int LocalDrivingLicenseApplicationID
        {
            get { return _LocalDrivingLicenseApplicationID; }
        }



        public LocalApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            _SelectedApplication = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (_SelectedApplication != null)
            {
                _SelectedApplication.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
                baseApplicationInfo1.LoadApplicationInfo(_SelectedApplication.ApplicationID);
                FillApplicationInfo();
            }
            else
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with Local Dirving License Application ID = " + LocalDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResetApplicationInfo()
        {
            _LocalDrivingLicenseApplicationID = -1;
            baseApplicationInfo1.ResetApplicationInfo();

            lblLocalLicenseApplication.Text = "[???]";
            lblClassName.Text = "[???]";

        }

        private void FillApplicationInfo()
        {
      
            lblLocalLicenseApplication.Text = _SelectedApplication.LocalDrivingLicenseApplicationID.ToString();
            lblClassName.Text = LicenseClass.Find(_SelectedApplication.LicenseClassID).ClassName;

        }

     
    }
}
