using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class ShowPersonInfo : Form
    {
        Person person;
        public ShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            personInfoCard1.PersonInfo(PersonID);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personInfoCard1_EvPassPersonInfo(Person obj)
        {

            personInfoCard1.Show();
        }
    }
}
