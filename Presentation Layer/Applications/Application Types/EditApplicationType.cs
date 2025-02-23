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

namespace Presentation_Layer.Application_Types
{
    public partial class EditApplicationType : Form
    {
        ApplicationType AppType;
        public EditApplicationType()
        {
            InitializeComponent();
        }

        public EditApplicationType(ApplicationType appType)
        {
            InitializeComponent();
            AppType = appType;
            lblIDValue.Text = appType.ApplicationTypeID.ToString();
            txtApplicationName.Text = appType.ApplicationTypeName;
            txtApplicationFee.Text = appType.ApplicationTypeFees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillUpdatedValues(AppType);
            if (AppType.UpdateApplicationType())
            {
                MessageBox.Show("Application Type was Updated Successfully");
            }
        }

        private void _FillUpdatedValues(ApplicationType Type)
        {
            Type.ApplicationTypeID = Int32.Parse(lblIDValue.Text);
            Type.ApplicationTypeName = txtApplicationName.Text;
            Type.ApplicationTypeFees = Decimal.Parse(txtApplicationFee.Text);
        }
    }
}
