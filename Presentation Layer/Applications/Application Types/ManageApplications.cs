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

namespace Presentation_Layer.Application_Types
{
    public partial class ManageApplications : Form
    {

        private int id;
        DataTable dt1;

        public ManageApplications()
        {
            InitializeComponent();
            showAllApplicationTypes();
        }

        private void showAllApplicationTypes()
        {

            dt1 = ApplicationType.GetAllApplicationTypes();

            dgvApplications.DataSource = dt1;
            dgvApplications.MouseUp += dgvApplications_MouseUp;
        }
        private void dgvApplications_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvApplications.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0)
                {
                    dgvApplications.ClearSelection();
                    dgvApplications.CurrentCell = dgvApplications[hitTest.ColumnIndex, hitTest.RowIndex];

                    id = (int)dgvApplications[0, hitTest.RowIndex].Value;

                }
            }
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationType appType = ApplicationType.GetApplicationTypeInformation((int)dgvApplications.CurrentRow.Cells[0].Value);
            
            if (appType != null)
            {
            EditApplicationType update = new EditApplicationType(appType);
            update.ShowDialog();
            }
            showAllApplicationTypes();

        }
    }
}
