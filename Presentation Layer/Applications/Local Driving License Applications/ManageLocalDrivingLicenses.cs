using BL;
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

namespace Presentation_Layer.Applications
{
    public partial class ManageLocalDrivingLicenses: Form
    {

        private int id;


        DataTable dtApplications, dtApplicationsView;



        public ManageLocalDrivingLicenses()
        {
            InitializeComponent();
        }


        private void ManageLocalDrivingLicenses_Load(object sender, EventArgs e)
        {
            ShowAllApplications();
            PrepareFilter();
        }

        private void ShowAllApplications()
        {
            dtApplications = LocalDrivingLicenseApplication.GetAllApplications();

            dtApplicationsView = dtApplications.DefaultView.ToTable(false, "LocalDrivingLicenseApplicationID" , "ClassName"
                ,"NationalNumber","FullName", "ApplicationDate", "ApplicationStatus");
            dgvLDLApplications.DataSource = dtApplicationsView;
            RenameColumns();

        }



        public void RenameColumns()
        {
            if (dgvLDLApplications.Rows.Count > 0)
            {
                dgvLDLApplications.Columns[0].HeaderText = "Application ID ";
                dgvLDLApplications.Columns[0].Width = 80;

                dgvLDLApplications.Columns[1].HeaderText = "Class Name";
                dgvLDLApplications.Columns[1].Width = 130;

                dgvLDLApplications.Columns[2].HeaderText = "National Number";
                dgvLDLApplications.Columns[2].Width = 130;

                dgvLDLApplications.Columns[3].HeaderText = "Full Name";
                dgvLDLApplications.Columns[3].Width = 150;

                dgvLDLApplications.Columns[4].HeaderText = "Application Date";
                dgvLDLApplications.Columns[4].Width = 130;

                dgvLDLApplications.Columns[5].HeaderText = "Application Status";
                dgvLDLApplications.Columns[5].Width = 130;


                lblRecordsCount.Text = dgvLDLApplications.Rows.Count.ToString();

            }
        }

        private void PrepareFilter()
        {

            foreach (DataGridViewColumn column in dgvLDLApplications.Columns)
            {
                ComboFilter.Items.Add(column.Name);
            }

            ComboFilter.SelectedIndex = 0;

        }


        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplications NewApplication = new LocalDrivingLicenseApplications();
            NewApplication.ShowDialog();
            ShowAllApplications();
        }

    
        private void txtFilter_Changed(object sender, EventArgs e)
        {
            string FilterName = ComboFilter.Text;

            if (txtFilter.Text == "" && FilterName != "")
            {
                // show them all 
                ShowAllApplications();
            }
            else
            {
                Result(txtFilter.Text, FilterName);
            }
        }


        private void Result(string text, string FilterName)
        {
            DataView Dv1 = new DataView(dtApplicationsView);
            if (FilterName.Equals("LocalDrivingLicenseApplicationID"))
            {
                Dv1.RowFilter = string.Format($"{FilterName} = {text}");
                
            }
            else
            {
                Dv1.RowFilter = FilterName + " LIKE '" + text + "%'";
            }
            dgvLDLApplications.DataSource = Dv1;
        }

        private void cmsApplicationOptions_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            
            LocalDrivingLicenseApplication LocalApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            tsmiEditLocalApplication.Enabled = (LocalApp.ApplicationStatus != LocalDrivingLicenseApplication.enApplicationStatus.Completed);
            tsmiDeleteLocalApplication.Enabled = (LocalApp.ApplicationStatus == LocalDrivingLicenseApplication.enApplicationStatus.New);
            tsmiCancelLocalApplication.Enabled = (LocalApp.ApplicationStatus == LocalDrivingLicenseApplication.enApplicationStatus.New);

        }

        private void tsmiApplicationDescription_Click(object sender, EventArgs e)
        {
            Form ApplicationInfo = new ShowApplicationInfo((int)dgvLDLApplications.CurrentRow.Cells[0].Value);
            ApplicationInfo.ShowDialog();
        }

        private void tsmiEditLocalApplication_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
            LocalDrivingLicenseApplications UpdateApplication = new LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID);

            UpdateApplication.ShowDialog();
            ShowAllApplications();
        }

        private void tsmiDeleteLocalApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Application?", "Delete Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int LocalDrivingLicenseApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
                LocalDrivingLicenseApplication LocalApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

                if (LocalApp.Delete())
                {
                    MessageBox.Show("Application was deleted successfully", "Application Deleted", MessageBoxButtons.OK);
                    ShowAllApplications();

                }
                else
                {
                    MessageBox.Show("Something Went Wrong!", "Application was not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tsmiCancelLocalApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change the status to \"Cancelled\"?", "Cancel Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int LocalDrivingLicenseApplicationID = (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
                LocalDrivingLicenseApplication LocalApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);
                if (LocalApp.Cancel())
                {
                    MessageBox.Show("Application was Cancelled successfully", "Application Cancelled", MessageBoxButtons.OK);
                    ShowAllApplications();

                }
                else
                {
                    MessageBox.Show("Something Went Wrong!", "Application was not Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvLDLApplications_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvLDLApplications.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0)
                {
                    dgvLDLApplications.ClearSelection();
                    dgvLDLApplications.CurrentCell = dgvLDLApplications[hitTest.ColumnIndex, hitTest.RowIndex];

                    id = (int)dgvLDLApplications[0, hitTest.RowIndex].Value;

                }
            }
        }



    }
}
