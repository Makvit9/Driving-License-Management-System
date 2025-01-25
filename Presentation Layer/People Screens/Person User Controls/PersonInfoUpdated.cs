using System.Windows.Forms;
using BL;
using Presentation_Layer.Properties;

namespace Presentation_Layer.People_Screens.Person_User_Controls
{
    public partial class PersonInfoUpdated : UserControl
    {

        private Person _SelectedPerson;
        private int _PersonID;

        public PersonInfoUpdated()
        {
            InitializeComponent();
        }

        public Person SelectedPerson
        {
            get { return _SelectedPerson; }
        }

        public int PersonID
        {
            get { return _PersonID; }
        }



        public void LoadPersonInfo(int PersonID)
        {
            _SelectedPerson = Person.Find(PersonID);

            if (_SelectedPerson != null)
            {
                _SelectedPerson.PersonID = PersonID;
                FillPersonInfo();
            }
        }

        public void LoadPersonInfo(string NationalNumber)
        {
            _SelectedPerson = Person.Find(NationalNumber);

            if (_SelectedPerson != null)
            {
                _SelectedPerson.NationalNumber = NationalNumber;
                FillPersonInfo();
            }
        }

        private void FillPersonInfo()
        {
            _PersonID = _SelectedPerson.PersonID;
            txtPersonID.Text = _SelectedPerson.PersonID.ToString();
            txtName.Text = $"{_SelectedPerson.FirstName} {_SelectedPerson.SecondName} {_SelectedPerson.ThirdName} {_SelectedPerson.LastName}";
            txtNationNo.Text = _SelectedPerson.NationalNumber;
            txtGender.Text = (_SelectedPerson.Gender == 'M' ? "Male" : "Female");
            txtPhone.Text = _SelectedPerson.Phone;
            txtEmail.Text = _SelectedPerson.Email;
            txtDateOfBirth.Text = _SelectedPerson.DateOfBirth.ToString();
            txtCountry.Text = Country.FindCountry((_SelectedPerson.CountryID));
            LoadProfilePicture();
            txtAddress.Text = _SelectedPerson.Address;


        }

        private void LoadProfilePicture()
        {
            if (_SelectedPerson.ImagePath == "")
            {
                pbProfile.Image = (_SelectedPerson.Gender == 'M' ? Resources.Male_User : Resources.Female_User);
            }
            else
            {
                pbProfile.ImageLocation = _SelectedPerson.ImagePath;
            }
        }

        private void ShowUpdatePersonForm(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPerson UpdatePerson = new AddEditPerson(_SelectedPerson.PersonID);
            UpdatePerson.ShowDialog();

            LoadPersonInfo(_PersonID);
        }
    }
}
