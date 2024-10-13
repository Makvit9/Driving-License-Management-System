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

namespace Presentation_Layer
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
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
    }
}
