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
        public int Country_ID
        {
            get { return CountriesComboBox.SelectedIndex; }
            set { Country_ID = value; }
        }


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
            _FillComboBox();
           
        }

        private void _FillComboBox()
        {
            DataTable dt = Country.GetAllCountries();
            List<string> countriesList = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                countriesList.Add(dr["Name"].ToString());
            }

            foreach (string country in countriesList)
            {

                CountriesComboBox.Items.Add(country);
            }
            CountriesComboBox.SelectedIndex = Country.GetCountryID("Jordan") - 1;
        }
        
        public void DefaultSelectionOnEdit(int CountryID)
        {
            CountriesComboBox.SelectedIndex = CountryID;
        }
               
        private void _CountriesComboBox_Leave(object sender, EventArgs e)
        {
             EvIndexSelected(CountriesComboBox.SelectedIndex + 1);
        }
    }
}
