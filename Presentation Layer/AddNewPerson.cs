using BL;
using System;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class AddNewPerson : Form
    {
        public enum enmode { AddNew = 0, Update = 1 };
        private enmode _mode;
        int _PersonID;
        Person _Person1;
        public AddNewPerson(int PersonID)
        {
            InitializeComponent();


            _PersonID = PersonID;
            if (PersonID == -1)
            {
                _mode = enmode.AddNew;
            }
            else
            {
                _mode = enmode.Update;
            }

        }


        private void AddNewPersonCar_EvPassPersonInfo(Person person)
        {

        }

        private void addNewPersonCard1_EvPassPersonInfo(Person obj)
        {
            obj.Save();
        }

        private void AddNewPerson_Activated(object sender, EventArgs e)
        {
            addNewPersonCard1.Current += AddNewPersonCard1_Current;
        }

        private void AddNewPersonCard1_Current()
        {
            this.Close();
        }


        private void _LoadInfo()
        {
            if (_mode == enmode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person1 = new Person();
                addNewPersonCard1.Show();
                return;
            }

            _Person1 = Person.Find(_PersonID);

            if (_Person1 == null)
            {
                MessageBox.Show($"This form will be closed because there's no Person with ID: {_PersonID} ");
                this.Close();
                return;
            }

            lblMode.Text = $"Edit Person ";
            lblPersonID.Text = _PersonID.ToString();

            _PrepareForEdit();

        }

        private void _PrepareForEdit()
        {
            addNewPersonCard1.ActivateEditMode(_Person1);
        }
        private void AddNewPerson_Load(object sender, EventArgs e)
        {
            _LoadInfo();
        }
    }
}
