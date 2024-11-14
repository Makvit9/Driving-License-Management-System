﻿using BL;
using Presentation_Layer.Custom_Controls;
using Presentation_Layer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (PersonID == -1)
            {
                _mode = enmode.AddNew;
            }
            else
            {
                _mode = enmode.Update;
            }

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
        }
        private void AddNewPersonCard_Load(object sender, EventArgs e)
        {
            //Default Profile Picture
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



        }

        private void _PerpareForEdit()
        {
            FirstNametxt.Text = _Person1.FirstName;
            SecondNametxt.Text = _Person1.SecondName;
            ThirdNametxt.Text = _Person1.ThirdName;
            LastNametxt.Text = _Person1.LastName;
            DateOfBirthtxt.Value = _Person1.DateOfBirth;
            Phonetxt.Text = _Person1.Phone;
            Emailtxt.Text = _Person1.Email;
            NationalNotxt.Text = _Person1.NationalNumber;
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
            ProfilePic.Image = SetProfilePicture(Resources.Male_User);

        }

        private void btnFemale_CheckedChanged(object sender, EventArgs e)
        {
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
                SaveImage(ProfilePicturePicker.FileName);

            }
            ProfilePic.ImageLocation = ProfilePicturePicker.FileName;

        }

        public void SaveImage(string Imagepath)
        {

            PictureName = Guid.NewGuid();
            //TODO: Needs to be changed to be more generic
            string NewPath = $"C:\\Pictures";
            string NewPicturePath = $"{NewPath}\\{PictureName}.jpg";

            if (!File.Exists(NewPath))
            {
                Directory.CreateDirectory(NewPath);
            }
            File.Copy(Imagepath, NewPicturePath);

            Imagepath = NewPicturePath;

        }


        private void createNewPerson(char gender)
        {
            if (EvPassPersonInfo != null)
            {
                EvPassPersonInfo(new Person

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
                    Address = AddressRtxt.Text
                }
                );
            }
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {

           
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
            Current?.Invoke();
        }

        private bool isTheCellEmpty(TextBox txt) => txt.Text == "";
       



        private void EmptyCellValidation(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Equals(""))
            {
                e.Cancel = true;
                errEmpty.SetError((TextBox)sender, "This can't be empty");
            }
            else
            {
                //(TextBox)sender.Validated += FirstNametxt_Validated;

            }


        }

        private void ClearError(object sender, EventArgs e)
        {
            //    errEmpty.SetError(this, "");
            errEmpty.Clear();
        }

        private void AddressRtxt_Validating(object sender, CancelEventArgs e)
        {
            //if ( (RichTextBox)sender == "")
            //{
            //    e.Cancel = true;
            //    errEmpty.SetError((RichTextBox)sender, "This can't be empty");
            //}
            //else
            //{
            //    //(TextBox)sender.Validated += FirstNametxt_Validated;

            //}
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


    }
}