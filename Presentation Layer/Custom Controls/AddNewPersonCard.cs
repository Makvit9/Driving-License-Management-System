using System;
using System.ComponentModel;
using System.Windows.Forms;
using BL;
using Syncfusion.ComponentModel;

namespace Presentation_Layer.Custom_Controls
{
    public partial class AddNewPersonCard : UserControl
    {
        public AddNewPersonCard()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = @"Png Pictures (*.Png)|*.Png|Jpeg Pictures (*.Jpeg)|*.Jpeg|Jpg Pictures (*.Jpg)|*.Jpg|All Files (*.*)|*.*";
            openFile.FileName = $"Untitled.{openFile.Filter}";

            openFile.Title = "Set a Profile Picture";
            openFile.InitialDirectory = "C:\\Users\\Majed\\Desktop";
            openFile.ShowDialog();
            //openFile.FileOk += OpenFile_FileOk;    
        }

        private void OpenFile_FileOk(object sender, CancelEventArgs e)
        {
            //MessageBox.Show("Hello"); 

        }


        //private void btnAddPerson_Click(object sender, EventArgs e)
        //{
        //    BL.Person person = new BL.Person(FirstNametxt.Text, SecondNametxt.Text, ThirdNametxt.Text, LastNametxt.Text, NationalNotxt.Text, 
        //        DateOfBirthtxt.Text, ,Phonetxt.Text, Emailtxt.Text,, AddressRtxt.Text);
        //}
    }
}
