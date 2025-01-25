using BL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace Presentation_Layer
{
    public partial class ManagePeople : Form
    {
        private int id;
        private int _personId;

        DataTable dtPeople;

        DataTable dtPeopleView;
        public ManagePeople()
        {
            InitializeComponent();
        }
        private void showAllPeople()
        {
            // This needs to be changed. No need for the picture path to be displayed 
            dtPeople = Person.GetAllPeople();

            dtPeopleView = dtPeople.DefaultView.ToTable(false, "PersonID", "NationalNumber", "FirstName"
                , "SecondName", "ThirdName", "LastName" ,"Gender","PhoneNumber","Email");

            dgvPeople.DataSource = dtPeopleView;
            RenameColumns();
            dgvPeople.MouseUp += dataGridView1_MouseUp;
        }

        public void RenameColumns()
        {
            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns[0].HeaderText = "Person ID ";
                dgvPeople.Columns[0].Width = 80;

                dgvPeople.Columns[1].HeaderText = "National Number";
                dgvPeople.Columns[1].Width = 130;

                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 100;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 110;

                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 100;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 100;

                dgvPeople.Columns[6].HeaderText = "Gender";
                dgvPeople.Columns[6].Width = 100;

                dgvPeople.Columns[7].HeaderText = "Phone Number";
                dgvPeople.Columns[7].Width = 115;

                dgvPeople.Columns[8].HeaderText = "Email";
                dgvPeople.Columns[8].Width = 115;


                lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

            }
        }
       
        private void PrepareFilter()
        {

            foreach (DataGridViewColumn column in dgvPeople.Columns)
            {
                ComboFilter.Items.Add(column.Name);
            }

            ComboFilter.SelectedIndex = 0;
            
        }

        private void Manage_People_Load(object sender, EventArgs e)
        {
            showAllPeople();
            PrepareFilter();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddNew = new AddEditPerson();
            AddNew.ShowDialog();
            showAllPeople();

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowInfo = new ShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            ShowInfo.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Add = new AddEditPerson();
            Add.Show();
            showAllPeople();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvPeople.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0)
                {
                    dgvPeople.ClearSelection();
                    dgvPeople.CurrentCell = dgvPeople[hitTest.ColumnIndex, hitTest.RowIndex];

                    id = (int)dgvPeople[0, hitTest.RowIndex].Value;

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _personId = (int)dgvPeople.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are you sure you want to delete person with ID= {_personId}?", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string path = ( Person.Find(_personId).ImagePath);
                if (Person.DeletePerson((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    DeleteImage(path);
                    MessageBox.Show("Person Deleted Successfully.");
                //    DeleteImage(dgvPeople.CurrentRow.Cells[12].Value.ToString());
                    
                    showAllPeople();
                }
                else
                {
                    MessageBox.Show("Person Can't be deleted because it's linked with a user");
                }
            }
        }

        private void DeleteImage(string Path)
        {
            if (Path != null)
            {
                File.Delete(Path);
            }
        }

        // This is activated when you change the index 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form EditPerson = new AddEditPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            EditPerson.ShowDialog();
            showAllPeople();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string FilterName = ComboFilter.Text;

            if (txtFilter.Text == "" && FilterName != "")
            {
                // show them all 
                showAllPeople();
            }
            else
            {
                Result(txtFilter.Text, FilterName);
            }


        }

        private void Result(string text, string FilterName)
        {
            DataView Dv1 = new DataView(dtPeople);
            if (FilterName == "PersonID" || FilterName == "Country_ID")
            {
                Dv1.RowFilter = string.Format($"{FilterName} = {text}");
            }
            else
            {
            Dv1.RowFilter = FilterName + " LIKE '" + text + "%'";
            }
            dgvPeople.DataSource = Dv1;
        }
   
    }
}
