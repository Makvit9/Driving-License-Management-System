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
        private void showAllUsers()
        {
            
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

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            showAllUsers();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Form AddUser = new AddNewUserUpdated();
            AddUser.ShowDialog();
            showAllUsers();
        }

        private void showUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form ShowInfo = new ShowUserInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            ShowInfo.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete User with ID= {dataGridView1.CurrentRow.Cells[0].Value}?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (User.DeleteUser((int)dataGridView1.CurrentRow.Cells[0].Value))
                {

                    MessageBox.Show("User Deleted Successfully.");
                    showAllUsers();
                }
                
            }
        }

        private void editCurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form Edit_User = new EditUser((int)dataGridView1.CurrentRow.Cells[0].Value);
            Edit_User.ShowDialog();
            showAllUsers();
        }

        private void changeUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ResetPassword = new ChangeUserPassword((int)dataGridView1.CurrentRow.Cells[0].Value);
            ResetPassword.ShowDialog();
        }
    }
}
