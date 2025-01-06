using BL;
using Presentation_Layer.Application_Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.TestTypes
{
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
            ShowAllTestTypes();
        }

        public void ShowAllTestTypes()
        {
            dt1 = TestType.GetAllApplicationTypes();

            dgvTestTypes.DataSource = dt1;
            dgvTestTypes.MouseUp += dgvTestTypes_MouseUp;
        }

        private int id;
        DataTable dt1;



        private void dgvTestTypes_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvTestTypes.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0)
                {
                    dgvTestTypes.ClearSelection();
                    dgvTestTypes.CurrentCell = dgvTestTypes[hitTest.ColumnIndex, hitTest.RowIndex];

                    id = (int)dgvTestTypes[0, hitTest.RowIndex].Value;

                }
            }
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestType testType = TestType.GetTestTypeInformation((int)dgvTestTypes.CurrentRow.Cells[0].Value);

            if (testType != null)
            {
                EditTestType update = new EditTestType(testType);
                update.ShowDialog();
            }
            ShowAllTestTypes();
        }
    }
}
