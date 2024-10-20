using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BL;

namespace Presentation_Layer
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewPersonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddNewPerson addNew = new AddNewPerson();
            addNew.MdiParent = this;
            addNew.Show();

        }

        private void showAllPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowAllPeople = new Form();
            ShowAllPeople.MdiParent = this;
            ShowAllPeople.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public void FillComboBox()
        {
            
        }


    }
}
