using System;
using System.Drawing;
using System.Windows.Forms;
using BL;

namespace Presentation_Layer.User_Controls
{
    public partial class PersonInfoCard : UserControl
    {
        public event Action<int> EvPassPersonID;
        protected virtual void PassPersonInfo(int personID)
        {
            Action<int> pass = EvPassPersonID;
            if (EvPassPersonID != null)
            {
                pass(personID);
            }
        }


        private int _PersonID;
        private Person _SelectedPerson;

        public PersonInfoCard()
        {
            InitializeComponent();
            



        }

        public void PersonInfo(int PersonID) 
        {

            _SelectedPerson = Person.Find(PersonID);

            if (_SelectedPerson != null)
            {
                _PersonID = PersonID;
                _fillTheCard(PersonID);
            }

        }

        public PersonInfoCard(int PersonID)
        {
            _SelectedPerson = Person.Find(PersonID);

            if (_SelectedPerson != null)
            {
                _fillTheCard(PersonID);
            }
        }
        private void _fillTheCard(int PersonID)
        {
            lblPersonID.Text = PersonID.ToString();
                _fillTheCard();
            }

        

        private void _fillTheCard()
        {
            lblPersonID.Text = _PersonID.ToString();
            
            lblFirstName.Text = _SelectedPerson.FirstName;
            lblSecondName.Text = _SelectedPerson.SecondName;
            lblThirdName.Text = _SelectedPerson.ThirdName;
            lblLastName.Text = _SelectedPerson.LastName;

            lblNationalNumber.Text = _SelectedPerson.NationalNumber;
            lblGender.Text = (_SelectedPerson.Gender == 'M' ? "Male" : "Female");
            lblPhoneNumber.Text = _SelectedPerson.Phone;
            lblEmail.Text = _SelectedPerson.Email;

            pbProfilePicture.ImageLocation = _SelectedPerson.ImagePath;
            lblAddress.Text = _SelectedPerson.Address;


        }

        private void PersonInfoCard_Load(object sender, EventArgs e)
        {

        }
    }
}
