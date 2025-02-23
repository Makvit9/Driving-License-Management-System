using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TestType
    {

        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }; 
        public enum enMode { AddNew = 0, Update = 1 };
        
        public enMode Mode = enMode.AddNew;

        public TestType.enTestType  TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }

        public string TestTypeDescription { get; set; }


        public decimal TestTypeFees { get; set; }


        public TestType(TestType.enTestType TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)

        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;

            this.TestTypeFees = TestTypeFees;
            Mode = enMode.Update;
        }



        public static DataTable GetAllApplicationTypes()
        {
            return TestTypeDAL.GetAllTestTypes();
        }



        public static TestType GetTestTypeInformation(TestType.enTestType TestTypeID)
        {
            string _TestTypeTitle = "";
            string _TestTypeDescription = "";
            decimal _TestTypeFees = -1;

            if (TestTypeDAL.GetTestTypeInfo((int)TestTypeID, ref _TestTypeTitle, ref _TestTypeDescription ,ref _TestTypeFees))
            {
                return new TestType( TestTypeID , _TestTypeTitle ,  _TestTypeDescription , _TestTypeFees );
            }

            return null;

        }

        public bool UpdateTestType()
        {
            return TestTypeDAL.UpdateTestType((int)this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription,  this.TestTypeFees);
        }

       

       

        








    }



}
