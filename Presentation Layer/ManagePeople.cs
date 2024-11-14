using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Syncfusion.Windows.Forms.Interop;
using Syncfusion.Windows.Forms.Tools;
namespace Presentation_Layer
{
    public partial class ManagePeople : Form
    {
        private int id;

        public ManagePeople()
        {
            InitializeComponent();
        }

        private void showAllPeople()
        {
            // This needs to be changed. No need for the picture path to be displayed 
            dataGridView1.DataSource = Person.GetAllPeople();
            dataGridView1.MouseUp += dataGridView1_MouseUp;
        }

       private void PrepareFilter()
        {
            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                ComboFilter.Items.Add(column.Name);
            }
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
          if (  MessageBox.Show($"Are you sure you want to delete person with ID= {dataGridView1.CurrentRow.Cells[0].Value}?", "Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)            
            {
                if (Person.DeletePerson((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.");
                    showAllPeople();
                }
            }
        }
        enum enFilterOptions { PersonID = 0, FirstName = 1, NationalNumber = 2};

        enFilterOptions Option;
        
        // This is activated when you change the index 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Option = (enFilterOptions)ComboFilter.SelectedIndex;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form EditPerson = new AddEditPerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            EditPerson.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (Option)
            {
                case enFilterOptions.PersonID:
                    //dataGridView1.Sort(dataGridView1["PersonID", 0].OwningColumn, ListSortDirection.Ascending);
                    
                    break;

                case enFilterOptions.FirstName:
                    //dataGridView1.Sort(dataGridView1["FirstName", 0].OwningColumn, ListSortDirection.Ascending);

                    break;

                case enFilterOptions.NationalNumber:
                    //dataGridView1.Sort(dataGridView1["NationalNumber", 0].OwningColumn, ListSortDirection.Ascending);

                    break;
            }
        }
    }
}
