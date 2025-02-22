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

namespace Presentation_Layer.Applications
{

     
    public partial class LocalDrivingLicenseApplications : Form
    {
        enum enMode { AddNew = 1 , Update = 2 };
        private enMode _Mode;

        private int LocalDrivingLicenseApplicationID = -1;
        private int PersonID = -1;
        private LocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        private DataTable _dtLicenseClasses;

        public LocalDrivingLicenseApplications()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public LocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {
            _Mode = enMode.Update;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            ctrlInfo.SelectTab(1);
            btnSave.Enabled = true;
        }

        private void LoadLicenseClasses()
        {
            _dtLicenseClasses = LicenseClass.GetAllLicenseClasses();

            foreach (DataRow Class in _dtLicenseClasses.Rows )
            {
                cbLicenseClasses.Items.Add(Class["ClassName"]);
            }
            cbLicenseClasses.SelectedIndex = 0;

        }

        private void ApplicationTab_Enter(object sender, EventArgs e)
        {
            LoadLicenseClasses();
          

        }

        private void ResetValues()
        {
            LoadLicenseClasses();

            if (_Mode == enMode.AddNew)
            {
            lblTitle.Text = "New Local Driving License Application";
                this.Text = "New Application (Local Driving License)";

                personInfoWithFIlter1.Focus();
                _LocalDrivingLicenseApplication = new LocalDrivingLicenseApplication();
               
                lblApplicationFees.Text = ApplicationType.GetApplicationTypeInformation((int)ApplicationInfo.enApplicationType.NewDrivingLicense).ApplicationTypeFees.ToString() ;
                lblApplicationDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                lblCreatedByUser.Text = Global.CurrentUser.LoggedInUser.Username;
                cbLicenseClasses.SelectedIndex = 2;

                tabApplicationInfo.Hide();
                btnSave.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update Local Driving License Application";
                this.Text = "Update Application (Local Driving License)";

            }
            
        }

        private void LoadApplicationData()
        {
            personInfoWithFIlter1.FilterEnabled = false;
            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show($"No Application with ID {LocalDrivingLicenseApplicationID} was found!! ");
            }

            personInfoWithFIlter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            lblLocalDrivingLicenseID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToString();
            cbLicenseClasses.SelectedIndex = _LocalDrivingLicenseApplication.LicenseClassID;
            lblApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            lblCreatedByUser.Text = _LocalDrivingLicenseApplication.CreatedByUserID.ToString();


            btnSave.Enabled = true;
        }

        private void LocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {

            ResetValues();

            if (_Mode == enMode.Update)
            {
                LoadApplicationData();


            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = LicenseClass.Find(cbLicenseClasses.SelectedIndex).LicenseClassID;

            int ActiveApplicationID = ApplicationInfo.GetActiveApplicationIDForLicenseClass(PersonID, ApplicationInfo.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, this one already has an active Application");
                cbLicenseClasses.Focus();
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = personInfoWithFIlter1.PersonID;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicationStatus = ApplicationInfo.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToDecimal(lblApplicationFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = Global.CurrentUser.LoggedInUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;

            if (_LocalDrivingLicenseApplication.Save())
            {
                lblLocalDrivingLicenseID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }

        private void LocalDrivingLicenseApplications_Activated(object sender, EventArgs e)
        {
            personInfoWithFIlter1.FilterFocus();
        }
    }
}
