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
using System.Runtime.InteropServices.WindowsRuntime;

namespace Presentation_Layer.Applications
{
    
    public partial class BaseApplicationInfo: UserControl
    {
        private ApplicationInfo _BaseApplication;
        private int _ApplicationID;

        public int ApplicationID
        {
            get
            {
                return _ApplicationID;
            }
        }
        public BaseApplicationInfo()
        {
            InitializeComponent();
        }

        private void FillApplicationInfo()
        {
            lblID.Text = _BaseApplication.ApplicationID.ToString();
            lblStatus.Text = _BaseApplication.StatusText;
            lblFees.Text = _BaseApplication.PaidFees.ToString();
            lblType.Text = ApplicationType.GetApplicationTypeInformation(_BaseApplication.ApplicationTypeID).ApplicationTypeName;
            lblApplicant.Text = Person.Find(_BaseApplication.ApplicantPersonID).Fullname;

            lblDate.Text = _BaseApplication.ApplicationDate.ToShortDateString();
            lblStatusDate.Text = _BaseApplication.LastStatusDate.ToShortDateString();

            lblCreatedBy.Text = User.FindUser(_BaseApplication.CreatedByUserID).Username;
        }




        public void LoadApplicationInfo(int ApplicationID)
        {
            _BaseApplication = ApplicationInfo.Find(ApplicationID);

            if (_BaseApplication != null)
            {
                _BaseApplication.ApplicationID = ApplicationID;
                FillApplicationInfo();
            }
            else
            {
                ResetApplicationInfo();
            }
        }

        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;
            lblID.Text = "[???]";
            lblStatus.Text = "[???]";
            lblType.Text = "[???]";
            lblFees.Text = "[???]";
            lblApplicant.Text = "[???]";
            lblDate.Text = "[???]";
            lblStatusDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        private void lnkPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonInfo personInfo = new ShowPersonInfo(_BaseApplication.ApplicantPersonID);
            personInfo.ShowDialog();
        }
    }
}
