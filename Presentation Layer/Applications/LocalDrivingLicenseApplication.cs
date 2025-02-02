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

     
    public partial class LocalDrivingLicenseApplication : Form
    {

        private DataTable _dtLicenseClasses;
        public LocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ctrlInfo.SelectTab(1);
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
            lblApplicationDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            LoadLicenseClasses();
          

        }
    }
}
