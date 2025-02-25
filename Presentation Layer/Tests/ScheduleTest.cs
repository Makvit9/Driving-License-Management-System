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

namespace Presentation_Layer.Tests
{
    public partial class ScheduleTest : Form
    {
        private int _AppointmentID = -1;
        private int _LocalDrivingLicenseApplicationID = -1;
        private TestType.enTestType _TestType = TestType.enTestType.VisionTest;

        public ScheduleTest(int LocalDrivingLicenseApplicationID, TestType.enTestType TestType, int AppointmentID = -1)
        {

            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
            _AppointmentID = AppointmentID;


        }

        public ScheduleTest()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            testScheduleControl1.TestTypeID = _TestType;
            testScheduleControl1.LoadInfo(_LocalDrivingLicenseApplicationID, _AppointmentID);


        }
    }
}
