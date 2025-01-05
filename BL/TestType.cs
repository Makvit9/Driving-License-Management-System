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

        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }

        public string TestTypeDescription { get; set; }


        public decimal TestTypeFees { get; set; }

        public static DataTable GetAllApplicationTypes()
        {
            return TestTypeDAL.GetAllTestTypes();
        }

        public static TestType GetTestTypeInformation(int TestTypeID)
        {
            string _TestTypeTitle = "";
            string _TestTypeDescription = "";
            decimal _TestTypeFees = -1;

            if (TestTypeDAL.GetTestTypeInfo(TestTypeID, ref _TestTypeTitle, ref _TestTypeDescription ,ref _TestTypeFees))
            {
                return new TestType { TestTypeID = TestTypeID, TestTypeTitle = _TestTypeTitle, TestTypeDescription = _TestTypeDescription , TestTypeFees = _TestTypeFees };
            }

            return null;

        }

        public bool UpdateTestType()
        {
            return TestTypeDAL.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription,  this.TestTypeFees);
        }
    }
}
