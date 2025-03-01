﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BL;
using Presentation_Layer.Application_Types;
using Presentation_Layer.TestTypes;
using Presentation_Layer.Applications;
using Syncfusion.Windows.Forms.Interop;
using Presentation_Layer.Users_Screens;


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

        private void ComingSoon(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes Test = new ManageTestTypes();
            Test.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplications LicenseApplication = new LocalDrivingLicenseApplications();
            LicenseApplication.ShowDialog();
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AccountSettings ChangePassword = new AccountSettings(Global.CurrentUser.LoggedInUser.UserID);
            ChangePassword.ShowDialog();
        }

        private void localDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenses Applications = new ManageLocalDrivingLicenses();
            Applications.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageApplications Application = new ManageApplications();
            Application.ShowDialog();
        }
    }
}
