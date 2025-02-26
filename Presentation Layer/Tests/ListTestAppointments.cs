using BL;
using Presentation_Layer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Tests
{
    public partial class ListTestAppointments: Form
    {

        private DataTable _dtTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private TestType.enTestType _TestType = TestType.enTestType.VisionTest;
        public ListTestAppointments()
        {
            InitializeComponent();
        }

        public ListTestAppointments(int LocalDrivingLicenseApplicationID, TestType.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenameRows()
        {
            if (dgvTestAppointments.Rows.Count > 0)
            {
                dgvTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvTestAppointments.Columns[0].Width = 150;

                dgvTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvTestAppointments.Columns[1].Width = 200;

                dgvTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvTestAppointments.Columns[2].Width = 150;

                dgvTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvTestAppointments.Columns[3].Width = 100;
            }

        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {

                case TestType.enTestType.VisionTest:
                    {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Vision_512;
                        break;
                    }

                case TestType.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        break;
                    }
                case TestType.enTestType.StreetTest:
                    {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        break;
                    }
            }
        }


        private void ListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();


            localApplicationInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplicationID);
            _dtTestAppointments = TestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicenseApplicationID, _TestType);

            dgvTestAppointments.DataSource = _dtTestAppointments;
            lblRecordsCount.Text = dgvTestAppointments.Rows.Count.ToString();

            RenameRows();
            
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplication localDrivingLicenseApplication = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);


            if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ScheduleTest FirstAppointment= new ScheduleTest(_LocalDrivingLicenseApplicationID,_TestType); //If the first time 
            FirstAppointment.ShowDialog();
            ListTestAppointments_Load(null, null);

        }

        private void tsmiEditAppointment_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;
            ScheduleTest EditAppointment = new ScheduleTest(_LocalDrivingLicenseApplicationID, _TestType, TestAppointmentID);
            EditAppointment.ShowDialog();
            ListTestAppointments_Load(null, null);

        }

        private void tsmiTakeTest_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;
            TakeTest TestToTake = new TakeTest(TestAppointmentID, _TestType);
            TestToTake.ShowDialog();

        }
    }
    }

