using BL;
using Presentation_Layer.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentation_Layer
{
    public partial class AddEditPerson : Form
    {
        public enum enmode { AddNew = 0, Update = 1 };
        private enmode _mode;
        int _PersonID;
        Person _Person1;
        public AddEditPerson()
        {
            InitializeComponent();

        }

        public AddEditPerson(int PersonID)
        {
            InitializeComponent();


            _PersonID = PersonID;
                _mode = enmode.Update;
                
            _Person1 = Person.Find(PersonID);
        }

        public delegate void CloseTheForm();
        public event CloseTheForm Current;



        public event Action<Person> EvPassPersonInfo;

        Guid PictureName;
        protected virtual void PassPersonInfo(Person person)
        {
            Action<Person> pass = EvPassPersonInfo;
            if (EvPassPersonInfo != null)
            {
                pass(person);
            }
        }

        public AddEditPerson(Person person)
        {
            ActivateEditMode(person);
            _mode = enmode.Update;
        }

        public void ActivateEditMode(Person person)
        {
            FirstNametxt.Text = person.FirstName;
            SecondNametxt.Text = person.SecondName;
            ThirdNametxt.Text = person.ThirdName;
            LastNametxt.Text = person.LastName;
            Phonetxt.Text = person.Phone;
            Emailtxt.Text = person.Email;
            NationalNotxt.Text = person.NationalNumber;
            ProfilePic.ImageLocation = person.ImagePath;
            AddressRtxt.Text = person.Address;
        }
        private void AddNewPersonCard_Load(object sender, EventArgs e)
        {
            //Default Profile Picture
            //ProfilePic.Image = SetProfilePicture(Resources.user);
            //Default Date
            DateOfBirthtxt.MaxDate = MaximumDate();
            DateOfBirthtxt.MinDate = MinimumDate();

            if (_mode == enmode.AddNew)
            {
                ProfilePic.Image = SetProfilePicture(Resources.Male_User);
                lblMode.Text = "Add New Person";
                _Person1 = new Person();
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

            _PerpareForEdit();



        }

        private void _PerpareForEdit()
        {
            FirstNametxt.Text = _Person1.FirstName;
            SecondNametxt.Text = _Person1.SecondName;
            ThirdNametxt.Text = _Person1.ThirdName;
            LastNametxt.Text = _Person1.LastName;
            DateOfBirthtxt.Value = _Person1.DateOfBirth;
            _CheckGender(_Person1.Gender);
            Phonetxt.Text = _Person1.Phone;
            Emailtxt.Text = _Person1.Email;
            NationalNotxt.Text = _Person1.NationalNumber;
            CountriesList.DefaultSelectionOnEdit(_Person1.CountryID);

            if (_Person1.ImagePath != "")
            {
                ProfilePic.ImageLocation = _Person1.ImagePath;
                linklblRemove.Visible = true;
            }
            else if (_Person1.Gender == 'M')
            {
                ProfilePic.Image=  SetProfilePicture(Resources.Male_User);
            }
            else
            {
                ProfilePic.Image = SetProfilePicture(Resources.Female_User);
            }
            
            AddressRtxt.Text = _Person1.Address;
        }

        private void _PrepareFormValues()
        {

            if (_mode == enmode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person1 = new Person();
            }
            else
            {
                lblMode.Text = "Edit Person Info";
                return;
            }


            if (btnMale.Checked)
                ProfilePic.Image = Resources.Male_User;
            else
                ProfilePic.Image = Resources.Female_User;

            linklblRemove.Visible = (ProfilePic.ImageLocation != null);


            MaximumDate();
            MinimumDate();




        }


        private void _CheckGender(Char gender)
        {
            if (gender == 'M')
                btnMale.Checked = true;
            else
                btnFemale.Checked = true;

            
        }

        private Image SetProfilePicture(Bitmap Picture)
        {
            return Picture;
        }
        private DateTime MaximumDate(int age = 18)
        {
            return new DateTime(DateTime.Today.Year - age, DateTime.Today.Month, DateTime.Today.Day);

        }
        private DateTime MinimumDate(int age = 80)
        {
            return new DateTime(DateTime.Today.Year - age, DateTime.Today.Month, DateTime.Today.Day);

        }

        private void DateOfBirthtxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (linklblRemove.Visible == false)
                ProfilePic.Image = SetProfilePicture(Resources.Male_User);

        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (linklblRemove.Visible == false)
                ProfilePic.Image = SetProfilePicture(Resources.Female_User);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ProfilePicturePicker = new OpenFileDialog();
            ProfilePicturePicker.Filter = @"Jpg Pictures (*.Jpg)|*.Jpg|Png Pictures (*.Png)|*.Png|Jpeg Pictures (*.Jpeg)|*.Jpeg|All Files (*.*)|*.*";
            ProfilePicturePicker.FileName = $"Untitled.{ProfilePicturePicker.Filter}";

            ProfilePicturePicker.Title = "Set a Profile Picture";
            ProfilePicturePicker.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            if (ProfilePicturePicker.ShowDialog() == DialogResult.OK)
            {
                ProfilePic.ImageLocation = SaveImage(ProfilePicturePicker.FileName);

            }
          
        }

        public string SaveImage(string Imagepath)
        {

            PictureName = Guid.NewGuid();
          
            string NewPath = $"C:\\Pictures";
            string NewPicturePath = $"{NewPath}\\{PictureName}.jpg";

            if (!File.Exists(NewPath))
            {
                Directory.CreateDirectory(NewPath);
            }
            File.Copy(Imagepath, NewPicturePath);



            linklblRemove.Visible = true;


            return NewPicturePath;

            

        }


        private void createNewPerson()//char gender)
        {
           
                Person p = new Person

                {
                    FirstName = FirstNametxt.Text,
                    SecondName = SecondNametxt.Text,
                    ThirdName = ThirdNametxt.Text,
                    LastName = LastNametxt.Text,
                    NationalNumber = NationalNotxt.Text,
                    DateOfBirth = DateOfBirthtxt.Value,
                    Gender = (btnMale.Checked== true)? 'M': 'F',
                    Phone = Phonetxt.Text,
                    Email = Emailtxt.Text,
                    //CountryID = Convert.ToInt32(CountriesList.Tag),
                    Address = AddressRtxt.Text,
                    ImagePath = ProfilePic.ImageLocation
                };
                p.Save();
            
        }


        private bool isTheCellEmpty(TextBox txt) => txt.Text == "";

        private void EmptyCellValidation(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                e.Cancel = true;
                errEmpty.SetError((TextBox)sender, "This can't be empty");
            }
          


        }

        private void ClearError(object sender, EventArgs e)
        {
            errEmpty.Clear();
            
        }



        public static bool IsEmailValid(string EmailAddress)
        {
            Regex rgx = new Regex(@"^[A-Z0-9a-z._%+-]{2,63}@(?:[A-Za-z0-9-]{1,125}\.)+[A-Za-z]{2,63}$");

            return rgx.IsMatch(EmailAddress);
            
               
            

        }

        private void CountriesList_EvIndexSelected(int obj)
        {
            CountriesList.Tag = obj.ToString();
        }


        private bool checkIfMatched(TextBox Number) => Regex.IsMatch(Number.Text, "[^0-9]");



        private void NumbersOnlyValidator(object sender, EventArgs e)
        {
            if (checkIfMatched((TextBox)sender))
            {
                errNumbersOnly.SetError((TextBox)sender, "Enter Numbers only");
            }
            else
            {
                errNumbersOnly.Clear();
            }
        }

        private void CountriesList_Load(object sender, EventArgs e)
        {
           
        }

        private void CountriesList_EvIndexSelected_1(int obj)
        {
            CountriesList.Tag = obj.ToString();
        }

        private void linklblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("This picture will be removed. Are you sure? ", "Remove Picture", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ProfilePic.ImageLocation != "")
                File.Delete(ProfilePic.ImageLocation);

                ProfilePic.ImageLocation = "";

                if(btnMale.Checked)
                ProfilePic.Image = SetProfilePicture(Resources.Male_User);


                if (btnFemale.Checked)
                ProfilePic.Image = SetProfilePicture(Resources.Female_User);


                linklblRemove.Visible = false;
            }
        }

        private void AddressRtxt_Leave(object sender, EventArgs e)
        {
            if (AddressRtxt.Text == "")
            {
                
                errEmpty.SetError(AddressRtxt, "This can't be empty");
               
            }
        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {
            if (!IsEmailValid(Emailtxt.Text))
            {
                errInvalidEmail.SetError(Emailtxt, "Email is not valid");
            }
            else
            {
                errInvalidEmail.Clear();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case (enmode.AddNew):
                    _SavePerson(_Person1, "User Was added successfully");
                    break;


                case (enmode.Update):
                    _SavePerson(_Person1, "User Was updated successfully");
                    break;
            }




            //_prepareToSave(_Person1);
            //_Person1.Save();

            
            btnSave.Enabled = false;

        }

        private void _SavePerson(Person P1, string Message)
        {
            _prepareToSave(_Person1);
            _Person1.Save();
            MessageBox.Show(Message);
        }

        private void _prepareToSave(Person selectedPerson)
        {
            if (_mode == enmode.Update)
                selectedPerson.PersonID = Int32.Parse(lblPersonID.Text);
            
            selectedPerson.FirstName = FirstNametxt.Text;
            selectedPerson.SecondName = SecondNametxt.Text;
            selectedPerson.ThirdName = ThirdNametxt.Text;
            selectedPerson.LastName = LastNametxt.Text;
            selectedPerson.NationalNumber = NationalNotxt.Text;
            selectedPerson.DateOfBirth = DateOfBirthtxt.Value;
            selectedPerson.Gender = (btnMale.Checked == true) ? 'M' : 'F';
            selectedPerson.Phone = Phonetxt.Text;
            selectedPerson.Email = Emailtxt.Text;
            selectedPerson.CountryID = CountriesList.Country_ID;
            selectedPerson.Address = AddressRtxt.Text;
            selectedPerson.ImagePath = ProfilePic.ImageLocation;
        
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}




// TODO (Add/Edit Screen) should be done ASAP:
// 1- Validation currently is turned off on all the textboxes, should be also fixed 
// 2- resolve bugs when removing the profile picture, and after setting a profile picture 
//      Now it's working, but it should change between the male and female 
// 3- Update should work (DONE) 
// * Validation on the Address (Not empty) (DONE)
// * Email Validation (DONE)

