using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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


        private void showAllPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public void FillComboBox()
        {
            
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowAll = new ManagePeople();
            ShowAll.MdiParent = this;

            ShowAll.Show();
            ShowAll.WindowState = FormWindowState.Maximized;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.Show();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowUsers = new Users_Screens.ManageUsers();
            ShowUsers.MdiParent = this;

            ShowUsers.Show();
            ShowUsers.WindowState = FormWindowState.Maximized;
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");

        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");

        }
    }
}
