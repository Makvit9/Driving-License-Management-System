using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class LocalDrivingLicenseApplication : ApplicationInfo
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int LocalDrivingLicenseApplicationID { get; set; }

        public int LicenseClassID { get; set; }

        public LicenseClass LicenseClassInfo { get; set; }

        public string FullName
        {
            get
            {
                return Person.Find(ApplicantPersonID).Fullname;
            }

        }

        public LocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;

            this.Mode = enMode.AddNew;
        }

        private LocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int LicenseClassID, int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID ) 
            : base (ApplicationID,ApplicantPersonID,ApplicationDate,ApplicationTypeID,ApplicationStatus,LastStatusDate, PaidFees, CreatedByUserID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;

            Mode = enMode.Update;
        }


        private bool AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationDAL.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
            return LocalDrivingLicenseApplicationID != -1;
        
        }

        private bool UpdateLocalDrivingLicenseApplication()
        {
            return LocalDrivingLicenseApplicationDAL.UpdateLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
        }

        public bool Save()
        {
            base.Mode = (ApplicationInfo.enMode) Mode;
            if (!base.Save())
                return false;


            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewLocalDrivingLicenseApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return UpdateLocalDrivingLicenseApplication();

            }

            return false;


        }




        public static LocalDrivingLicenseApplication FindByApplicationID(int ApplicationID)
        {
      
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            bool IsFound = LocalDrivingLicenseApplicationDAL.GetLocalDrivingLicenseApplicationInfoByApplicationID
                (ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                ApplicationInfo Application = ApplicationInfo.Find(ApplicationID);

                return new LocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, LicenseClassID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                    Application.ApplicationDate, Application.ApplicationTypeID,
                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, Application.CreatedByUserID);
            }
            else
                return null;


        }


        public static LocalDrivingLicenseApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
        {
            // 
            int ApplicationID = -1, LicenseClassID = -1;

            bool IsFound = LocalDrivingLicenseApplicationDAL.GetLocalDrivingLicenseApplicationInfoByID
                (LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application
                ApplicationInfo Application = ApplicationInfo.Find(ApplicationID);

                //we return new object of that person with the right data
                return new LocalDrivingLicenseApplication(
                    LocalDrivingLicenseApplicationID, LicenseClassID,
                    Application.ApplicationID,Application.ApplicantPersonID,
                    Application.ApplicationDate, Application.ApplicationTypeID,
                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, Application.CreatedByUserID);
            }
            else
                return null;


        }


    }
}
