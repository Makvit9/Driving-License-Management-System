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
namespace Presentation_Layer
{
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
        }

        private void showAllPeople()
        {
            dataGridView1.DataSource = Person.GetAllPeople();
        }
        private void Manage_People_Load(object sender, EventArgs e)
        {
            showAllPeople();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddNew = new AddNewPerson();
            AddNew.ShowDialog();
        }
    }
}
