﻿using BL;
using Presentation_Layer.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class AddEditPerson : Form
    {
        public enum enmode { AddNew = 0, Update = 1 };
        private enmode _mode;
        Guid PictureName;
        
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
            if (PersonID == -1)
            {
                _mode = enmode.AddNew;
            }
            else
            {
                _mode = enmode.Update;
                linklblRemove.Visible = true;
            }

        }

        public delegate void CloseTheForm();
        public event CloseTheForm Current;


        // This event handles invoking this Form and send the info back to the Grid 
        public event Action<Person> EvPassPersonInfo;

        
        
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
        }
        private void AddNewPersonCard_Load(object sender, EventArgs e)
        {
            //Default Profile Picture (needs to be fixed) 
            ProfilePic.Image = SetProfilePicture(Resources.user);
            //Default Date
            DateOfBirthtxt.MaxDate = MaximumDate();
            DateOfBirthtxt.MinDate = MinimumDate();

            if (_mode == enmode.AddNew)
            {
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

            //Here the edit is not working properly, it should make full update instead of resetting the whole thing 

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
            ProfilePic.ImageLocation = _Person1.ImagePath;
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
            if (ProfilePic.Image == Resources.user || ProfilePic.Image == Resources.Female_User)
            ProfilePic.Image = SetProfilePicture(Resources.Male_User);

        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (ProfilePic.Image == Resources.user || ProfilePic.Image == Resources.Male_User)
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


        private void createNewPerson(char gender)
        {
           
                Person p = new Person

                {
                    FirstName = FirstNametxt.Text,
                    SecondName = SecondNametxt.Text,
                    ThirdName = ThirdNametxt.Text,
                    LastName = LastNametxt.Text,
                    NationalNumber = NationalNotxt.Text,
                    DateOfBirth = DateOfBirthtxt.Value,
                    Gender = gender,
                    Phone = Phonetxt.Text,
                    Email = Emailtxt.Text,
                    CountryID = Convert.ToInt32(CountriesList.Tag),
                    Address = AddressRtxt.Text,
                    ImagePath = ProfilePic.ImageLocation
                };
                p.Save();
            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Here should do it differently. like the 

            if (btnMale.Checked)
            {
                createNewPerson('M');

                MessageBox.Show("Saved Successfully");

            }
            else if (btnFemale.Checked)
            {
                createNewPerson('F');
                MessageBox.Show("Saved Successfully");

            }

            else
            {
                MessageBox.Show("You should pick a gender", "Pick a Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                File.Delete(ProfilePic.ImageLocation);
                ProfilePic.Image = SetProfilePicture(Resources.Male_User);
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
    }
}




// TODO (Add/Edit Screen) should be done ASAP:
// 1- Validation currently is turned off on all the textboxes, should be also fixed 
// 2- resolve bugs when removing the profile picture, and after setting a profile picture 
//      Now it's working, but it should change between the male and female 
// 3- Update should work 
// * Validation on the Address (Not empty) (DONE)
// * Email Validation (DONE)

