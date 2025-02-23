using BL;
using Syncfusion.Windows.Forms.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.People_Screens.User_Controls
{
    public partial class PersonInfoWithFIlter : UserControl
    {
        public event Action<int> OnPersonSelected; 

        protected virtual void PersonSelected(int personID)
        {
            OnPersonSelected?.Invoke(personID);
        }

        
        private bool _ShowAddPersonButton = true;

        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPersonButton;
            }
            set
            {
                _ShowAddPersonButton = value;
                btnAdd.Visible = _ShowAddPersonButton;
            }
        }



        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }

            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }


        public void FilterFocus()
        {
            txtFilter.Focus();
        }

        public int PersonID
        {
            get { return personInfoUpdated1.PersonID; }
        }

        public Person SelectedPerson
        {
            get { return personInfoUpdated1.SelectedPerson; }
        }

        public PersonInfoWithFIlter()
        {
            InitializeComponent();
        }


        public void LoadPersonInfo(int personID)
        {

            cbFilters.SelectedIndex = 1;
            txtFilter.Text = personID.ToString();
            FindPerson();

        }

        private void FindPerson()
        {
            switch (cbFilters.Text)
            {
                case "Person ID":
                    personInfoUpdated1.LoadPersonInfo(int.Parse(txtFilter.Text));
                    break;
                case "National Number":
                    personInfoUpdated1.LoadPersonInfo(txtFilter.Text);
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
            {
                OnPersonSelected(personInfoUpdated1.PersonID);
            }
        }

        private void ClickFind(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindPerson();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void PersonInfoWithFIlter_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            txtFilter.Focus();
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                e.Cancel = true;
                errorProviderEmptyTxt.SetError(txtFilter, "This should not be empty! ");
            }
            else
            {

            }
        }

        private void txtFilter_Validated(object sender, EventArgs e)
        {
            errorProviderEmptyTxt.Clear();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            AddEditPerson addPerson = new AddEditPerson();
            addPerson.DataBack += DataBackEvent;
            addPerson.ShowDialog();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            cbFilters.SelectedIndex = 1;
            txtFilter.Text = PersonID.ToString();
            personInfoUpdated1.LoadPersonInfo(PersonID);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //picFind.per
            }

            if (cbFilters.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);            

            
        }
    }
}
