using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ApplicationType
    {

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeName { get; set; }

        public decimal ApplicationTypeFees { get; set; }

        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypeDAL.GetAllApplications();
        }

        public static ApplicationType GetApplicationTypeInformation(int ApplicationTypeID)
        {
            string _ApplicationTypeName = "";
            decimal _ApplicationTypeFees = -1;
            
            if (ApplicationTypeDAL.GetApplicationTypeInfo(ApplicationTypeID, ref _ApplicationTypeName, ref _ApplicationTypeFees))
            {
                return new ApplicationType { ApplicationTypeID = ApplicationTypeID, ApplicationTypeName = _ApplicationTypeName, ApplicationTypeFees = _ApplicationTypeFees };
            }

            return null;
        
        }

        public bool UpdateApplicationType()
        {
            return ApplicationTypeDAL.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeName, this.ApplicationTypeFees);
        }

    }
}
