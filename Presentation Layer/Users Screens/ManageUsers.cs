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

namespace Presentation_Layer.Users_Screens
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private int id;
        DataTable dt1;
        private void showAllPeople()
        {
            // This needs to be changed. No need for the picture path to be displayed 
            dt1 = User.GetAllUsers();

            dataGridView1.DataSource = dt1;
            dataGridView1.MouseUp += DataGridView1_MouseUp;
        }

        private void DataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dataGridView1.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = dataGridView1[hitTest.ColumnIndex, hitTest.RowIndex];

                    id = (int)dataGridView1[0, hitTest.RowIndex].Value;

                }
            }
        }
    }
}
