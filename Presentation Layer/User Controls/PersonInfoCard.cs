using System.Windows.Forms;
using BL;

namespace Presentation_Layer.User_Controls
{
    public partial class PersonInfoCard : UserControl
    {

        private int _PersonID;
        private Person _SelectedPerson;

        public PersonInfoCard()
        {
            InitializeComponent();

          

        }

        public PersonInfoCard(int PersonID)
        {
            _SelectedPerson = Person.Find(PersonID);

            if (_SelectedPerson != null)
            {
                _fillTheCard();
            }

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


        }
    }
}
