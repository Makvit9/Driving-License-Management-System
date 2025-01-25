using BL;
using Presentation_Layer.People_Screens.Validators;
using Presentation_Layer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class AddEditPerson : Form
    {

        public delegate void DataBackEventHandler(object sender, int PersonID);

        
        public event DataBackEventHandler DataBack;




        public enum enmode { AddNew = 0, Update = 1 };
        private enmode _Mode;
        int _PersonID;
        Person _Person1;
        Guid PictureName;
        string OldImagePath = "";
        string NewImagePath = ""; 
        public AddEditPerson()
        {
            InitializeComponent();
            _FillCountries();
        }

        public AddEditPerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enmode.Update;
            _Person1 = Person.Find(PersonID);
        }


        public AddEditPerson(Person person)
        {
            InitializeComponent();

            ActivateEditMode(person);
            _Mode = enmode.Update;
            _Person1 = person;
        }

        private void _LoadForm(object sender, EventArgs e)
        {
            _FillCountries();
            dtpBirthdate.MaxDate = MaximumDate();
            dtpBirthdate.MinDate = MinimumDate();


            if (_Mode == enmode.AddNew)
            {
                picProfile.Image = SetProfilePicture(Resources.Male_User);
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








        public void ActivateEditMode(Person person)
        {
            txtFirstname.Text = person.FirstName;
            txtSecondname.Text = person.SecondName;
            txtThirdname.Text = person.ThirdName;
            txtLastname.Text = person.LastName;
            txtPhone.Text = person.Phone;
            txtEmail.Text = person.Email;
            txtNationalNumber.Text = person.NationalNumber;
            rtxAddress.Text = person.Address;
            picProfile.ImageLocation = person.ImagePath;
        }


        private void _FillCountries()
        {
            DataTable dt = Country.GetAllCountries();
            List<string> countriesList = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                countriesList.Add(dr["Name"].ToString());
            }

            foreach (string country in countriesList)
            {

                cboCountries.Items.Add(country);
            }

            cboCountries.SelectedIndex = Country.GetCountryID("Jordan") - 1;
        }
        
     

        private void _PerpareForEdit()
        {

            txtFirstname.Text = _Person1.FirstName;
            txtSecondname.Text = _Person1.SecondName;
            txtThirdname.Text = _Person1.ThirdName;
            txtLastname.Text = _Person1.LastName;
            dtpBirthdate.Value = _Person1.DateOfBirth;
            _CheckGender(_Person1.Gender);
            txtPhone.Text = _Person1.Phone;
            txtEmail.Text = _Person1.Email;
            txtNationalNumber.Text = _Person1.NationalNumber;
            cboCountries.SelectedIndex = _Person1.CountryID - 1;


            if (_Person1.ImagePath != "")
            {
                picProfile.ImageLocation = _Person1.ImagePath;
                lnkRemove.Visible = true;
            }
            else if (_Person1.Gender == 'M')
            {
                picProfile.Image = SetProfilePicture(Resources.Male_User);
            }
            else
            {
                picProfile.Image = SetProfilePicture(Resources.Female_User);
            }

            rtxAddress.Text = _Person1.Address;
        }
        private void _CheckGender(Char gender)
        {
            if (gender == 'M')
                btnMale.Checked = true;
            else
                btnFemale.Checked = true;
        }

        private Image SetProfilePicture(Bitmap Picture) => Picture;


        //TODO: Remove this 

        //private void _PrepareFormValues()
        //{

        //    if (_mode == enmode.AddNew)
        //    {
        //        lblMode.Text = "Add New Person";
        //        _Person1 = new Person();
        //    }
        //    else
        //    {
        //        lblMode.Text = "Edit Person Info";
        //        return;
        //    }


        //    if (btnMale.Checked)
        //        picProfile.Image = Resources.Male_User;
        //    else
        //        picProfile.Image = Resources.Female_User;

        //    linklblRemove.Visible = (picProfile.ImageLocation != null);

        //}


     

        private DateTime MaximumDate(int age = 18)
        {
            return new DateTime(DateTime.Today.Year - age, DateTime.Today.Month, DateTime.Today.Day);

        }
        private DateTime MinimumDate(int age = 80)
        {
            return new DateTime(DateTime.Today.Year - age, DateTime.Today.Month, DateTime.Today.Day);

        }

        private void btnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (lnkRemove.Visible == false)
                picProfile.Image = SetProfilePicture(Resources.Male_User);

        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (lnkRemove.Visible == false)
                picProfile.Image = SetProfilePicture(Resources.Female_User);

        }

        

        private string SaveImage(string imagePath)
        {

            PictureName = Guid.NewGuid();

            string NewPath = Settings.Default.ImageStoragePath;

            string NewPicturePath = $"{NewPath}\\{PictureName}.jpg";

            if (!File.Exists(NewPath))
            {
                Directory.CreateDirectory(NewPath);
            }
            File.Copy(imagePath, NewPicturePath);

            lnkRemove.Visible = true;

            return NewPicturePath;

        }

        private void createNewPerson()//char gender)
        {

            Person p = new Person

            {
                FirstName = txtFirstname.Text,
                SecondName = txtSecondname.Text,
                ThirdName = txtThirdname.Text,
                LastName = txtLastname.Text,
                NationalNumber = txtNationalNumber.Text,
                DateOfBirth = dtpBirthdate.Value,
                Gender = (btnMale.Checked == true) ? 'M' : 'F',
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                CountryID = cboCountries.SelectedIndex,
                Address = rtxAddress.Text,
                ImagePath = picProfile.ImageLocation
            };
            p.Save();

        }

        
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



        private void AddressRtxt_Leave(object sender, EventArgs e)
        {

            if (Validators.IsTheCellEmpty( rtxAddress.Text ))
            {

                errEmpty.SetError(rtxAddress, "This can't be empty");

            }

        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {
            if (!Validators.IsEmailValid(txtEmail.Text))
            {
                errInvalidEmail.SetError(txtEmail, "Email is not valid");
            }
            else
            {
                errInvalidEmail.Clear();
            }
        }


        private void DeleteOldImage(string path)
        {
            if (path != "")
            {
                File.Delete(path);
            }
        }

        private void _SavePerson(Person personToSave, string message)
        {
            if (NewImagePath != "")
                picProfile.ImageLocation = SaveImage(NewImagePath);
            
            _prepareToSave(personToSave);
            DeleteOldImage(OldImagePath);
            personToSave.Save();
            MessageBox.Show(message);
        }

        private void _prepareToSave(Person selectedPerson)
        {
            if (_Mode == enmode.Update)
            {
                selectedPerson.PersonID = Int32.Parse(lblPersonID.Text);
            }

            selectedPerson.FirstName = txtFirstname.Text;
            selectedPerson.SecondName = txtSecondname.Text;
            selectedPerson.ThirdName = txtThirdname.Text;
            selectedPerson.LastName = txtLastname.Text;
            selectedPerson.NationalNumber = txtNationalNumber.Text;
            selectedPerson.DateOfBirth = dtpBirthdate.Value;
            selectedPerson.Gender = (btnMale.Checked == true) ? 'M' : 'F';
            selectedPerson.Phone = txtPhone.Text;
            selectedPerson.Email = txtEmail.Text;
            selectedPerson.CountryID = cboCountries.SelectedIndex + 1;
            selectedPerson.Address = rtxAddress.Text;
            selectedPerson.ImagePath = picProfile.ImageLocation;

        }


        
        

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ProfilePictureDialog()
        {
            OpenFileDialog ProfilePicturePicker = new OpenFileDialog();
            ProfilePicturePicker.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            ProfilePicturePicker.Title = "Set a Profile Picture";
            ProfilePicturePicker.Filter = @"Jpg Pictures (*.Jpg)|*.Jpg|Png Pictures (*.Png)|*.Png|Jpeg Pictures (*.Jpeg)|*.Jpeg|All Files (*.*)|*.*";
            ProfilePicturePicker.FilterIndex = 0;


            if (ProfilePicturePicker.ShowDialog() == DialogResult.OK)
            {
                NewImagePath = ProfilePicturePicker.FileName;
                picProfile.ImageLocation = (ProfilePicturePicker.FileName);
                MessageBox.Show("The Image has changed successfully, Don't forget to click save", "Profie picture is set");
            }
        }

        private void SetProfilePic(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (picProfile.ImageLocation != null)
            {


                if (picProfile.ImageLocation.Contains(Settings.Default.ImageStoragePath))
                {
                    OldImagePath = picProfile.ImageLocation;
                }



                if (MessageBox.Show("This image will be deleted, are you sure?", "Image delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    ProfilePictureDialog();


                }
            }
            else
            {
            ProfilePictureDialog();
            }
            
        }
        private void RemoveProfilePic(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("This picture will be removed. Are you sure? ", "Remove Picture", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (picProfile.ImageLocation != "")
                    File.Delete(picProfile.ImageLocation);

                picProfile.ImageLocation = "";

                if (btnMale.Checked)
                    picProfile.Image = SetProfilePicture(Resources.Male_User);


                if (btnFemale.Checked)
                    picProfile.Image = SetProfilePicture(Resources.Female_User);


                lnkRemove.Visible = false;
            }
        }

        private void ClickSave(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case (enmode.AddNew):
                    _SavePerson(_Person1, "User Was added successfully");
                    DataBack?.Invoke(this, _Person1.PersonID);
                    break;


                case (enmode.Update):
                    _SavePerson(_Person1, "User Was updated successfully");
                    DataBack?.Invoke(this, _Person1.PersonID);
                    break;
            }

            //_prepareToSave(_Person1);
            //_Person1.Save();

            btnSave.Enabled = false;
        }
    }
}


// TODO (Add/Edit Screen) should be done ASAP:
// 1- Validation currently is turned off on all the textboxes, should be also fixed (DONE)
// 2- resolve bugs when removing the profile picture, and after setting a profile picture 
//      Now it's working, but it should change between the male and female (RESOLVED)
// 3- Update should work (DONE) 
// * Validation on the Address (Not empty) (DONE)
// * Email Validation (DONE)

