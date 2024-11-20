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

        public ManagePeople()
        {
            InitializeComponent();
        }
        DataTable dt1;
        private void showAllPeople()
        {
            // This needs to be changed. No need for the picture path to be displayed 
            dt1 = Person.GetAllPeople();

            dataGridView1.DataSource = dt1;
            dataGridView1.MouseUp += dataGridView1_MouseUp;
        }

        private void PrepareFilter()
        {

            foreach (DataGridViewColumn column in dataGridView1.Columns)
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
            Form AddNew = new AddEditPerson(-1);
            AddNew.ShowDialog();
            showAllPeople();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowInfo = new ShowPersonInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            ShowInfo.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Add = new AddEditPerson(-1);
            Add.Show();
            showAllPeople();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete person with ID= {dataGridView1.CurrentRow.Cells[0].Value}?", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteImage(dataGridView1.CurrentRow.Cells[12].Value.ToString());
                
                if (Person.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    
                    MessageBox.Show("Person Deleted Successfully.");
                    showAllPeople();
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
            Form EditPerson = new AddEditPerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            EditPerson.ShowDialog();
            showAllPeople();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string FilterName = ComboFilter.Text;

            if (textBox1.Text == "" && FilterName != "")
            {
                // show them all 
                showAllPeople();
            }
            else
            {
                Result(textBox1.Text, FilterName);
            }


        }

        private void Result(string text, string FilterName)
        {
            DataView Dv1 = new DataView(dt1);
            Dv1.RowFilter = FilterName + " LIKE '" + text + "%'";
            dataGridView1.DataSource = Dv1;
        }
    }
}
