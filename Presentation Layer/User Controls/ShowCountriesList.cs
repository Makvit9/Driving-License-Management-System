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

namespace Presentation_Layer.Custom_Controls
{
    public partial class ShowCountriesList : UserControl
    {

        public event Action<int> EvIndexSelected;

        protected virtual void IndexSelected(int Index)
        {
            Action<int> pass = EvIndexSelected;
            if (EvIndexSelected != null)
            {
                pass(Index);
            }
        }

        public ShowCountriesList()
        {
            InitializeComponent();
            FillComboBox();
           
        }

        private void FillComboBox()
        {
            DataTable dt = Country.GetAllCountries();
            List<string> countriesList = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                countriesList.Add(dr["Name"].ToString());
            }

            foreach (string country in countriesList)
            {

                comboBox1.Items.Add(country);
            }
            comboBox1.SelectedIndex = 114;
        }
        
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            EvIndexSelected(comboBox1.SelectedIndex + 1);
        }
    }
}
