using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.TestTypes
{
    public partial class EditTestType : Form
    {
        TestType Test;

        public EditTestType()
        {
            InitializeComponent();
        }


        public EditTestType(TestType testType)
        {
            InitializeComponent();
            Test = testType;
            lblTestTypeID.Text = testType.TestTypeID.ToString();
            txtTestTypeTitle.Text = testType.TestTypeTitle;
            txtTestTypeDescription.Text = testType.TestTypeDescription;
            txtTestTypeFee.Text = testType.TestTypeFees.ToString();
        }

        private void _FillUpdatedValues(TestType _Test)
        {
            _Test.TestTypeID =(TestType.enTestType) Int32.Parse(lblTestTypeID.Text);
            _Test.TestTypeTitle= txtTestTypeTitle.Text;
            _Test.TestTypeDescription= txtTestTypeDescription.Text;
            _Test.TestTypeFees = Decimal.Parse(txtTestTypeFee.Text);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillUpdatedValues(Test);
            if (Test.UpdateTestType())
            {
                MessageBox.Show("Updated the Test type successfully");
            }
        }
    }
}
