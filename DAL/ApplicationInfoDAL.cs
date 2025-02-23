using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationInfoDAL
    {
        

       

        public static bool GetApplicationInfoByID(int ApplicationID,
           ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID,
           ref byte ApplicationStatus, ref DateTime LastStatusDate,
           ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string Query = @"SELECT * FROM Applications 
                             WHERE 
                             ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    isFound = true;
                }
                else
                {
                    isFound = false;
                }

                reader.Close();

            }


            catch (Exception ex)
            {

                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }
        
        public static DataTable GetAllApplications()
        {

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = "select * from ApplicationsList_View order by ApplicationDate desc";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }


        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID)
        {

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            int ApplicationID = -1;


            string query = @"INSERT INTO Applications ( 
                            ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                            ApplicationStatus,LastStatusDate,
                            PaidFees,CreatedByUserID)
                             VALUES (@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                      @ApplicationStatus,@LastStatusDate,
                                      @PaidFees,   @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("ApplicantPersonID", @ApplicantPersonID);
            cmd.Parameters.AddWithValue("ApplicationDate", @ApplicationDate);
            cmd.Parameters.AddWithValue("ApplicationTypeID", @ApplicationTypeID);
            cmd.Parameters.AddWithValue("ApplicationStatus", @ApplicationStatus);
            cmd.Parameters.AddWithValue("LastStatusDate", @LastStatusDate);
            cmd.Parameters.AddWithValue("PaidFees", @PaidFees);
            cmd.Parameters.AddWithValue("CreatedByUserID", @CreatedByUserID);




            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }

            catch (Exception ex)
            {
               

            }

            finally
            {
                conn.Close();
            }


            return ApplicationID;

        }
        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID)
        {
            int rowsAffected = 0;
            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"Update  Applications  
                            set ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus, 
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID=@CreatedByUserID
                            where ApplicationID=@ApplicationID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("ApplicantPersonID", @ApplicantPersonID);
            cmd.Parameters.AddWithValue("ApplicationDate", @ApplicationDate);
            cmd.Parameters.AddWithValue("ApplicationTypeID", @ApplicationTypeID);
            cmd.Parameters.AddWithValue("ApplicationStatus", @ApplicationStatus);
            cmd.Parameters.AddWithValue("LastStatusDate", @LastStatusDate);
            cmd.Parameters.AddWithValue("PaidFees", @PaidFees);
            cmd.Parameters.AddWithValue("CreatedByUserID", @CreatedByUserID);


            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                conn.Close();
            }

            return (rowsAffected > 0);

        }

        public static bool DeleteApplication(int ApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"Delete Applications 
                                where ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                conn.Open();

                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                
            }
            finally
            {

                conn.Close();

            }

            return (rowsAffected > 0);
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = "SELECT Found=1 FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }


        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {

            return (GetActiveApplicationID(PersonID, ApplicationTypeID) != -1);
        }

        public static int GetActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            int ActiveApplicationID = -1;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"SELECT ActiveApplicationID=ApplicationID FROM Applications 
                             WHERE 
                             ApplicantPersonID = @ApplicantPersonID and 
                             ApplicationTypeID=@ApplicationTypeID and 
                             ApplicationStatus=1";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationID;
            }
            finally
            {
                conn.Close();
            }

            return ActiveApplicationID;
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationID;
            }
            finally
            {
                conn.Close();
            }

            return ActiveApplicationID;
        }

        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {
            int rowsAffected = 0;
            SqlConnection conn = new SqlConnection(Settings.ConnectionString.connectionString);

            string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID=@ApplicationID;";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@NewStatus", NewStatus);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                conn.Close();
            }

            return (rowsAffected > 0);
        }




        }
}
