﻿using System;
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
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            menuStrip1.Show();
        }
    }
}
