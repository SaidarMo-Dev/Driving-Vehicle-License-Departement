using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data ;

namespace DVLDDataAccessLayer
{
    public class clsInternationalLicenseDataAccess
    {
        public static bool GetInternationalLicenseInfoByID(int InternationalLicenseID, ref int ApplicationID,
                            ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, 
                            ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID )
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM InternationalLicenses 
                               
                             WHERE  InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader .Read ())
                {
                    IsFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];



                }
            }
            catch
            {
                IsFound = false;
            }

            connection.Close();

            return IsFound;
        }

        public static int AddNewInternationalLicense(int ApplicationID,int DriverID,
                            int IssuedUsingLocalLicenseID, DateTime IssueDate,
                            DateTime ExpirationDate, bool IsActive,int CreatedByUserID)
        {
            int InsertedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"

                        INSERT INTO InternationalLicenses
                                   (
		                           ApplicationID
                                   ,DriverID
                                   ,IssuedUsingLocalLicenseID
                                   ,IssueDate
                                   ,ExpirationDate
                                   ,IsActive
                                   ,CreatedByUserID)
                             
                            VALUES
                                   (
		                            @ApplicationID
                                   ,@DriverID
                                   ,@IssuedUsingLocalLicenseID
                                   ,@IssueDate
                                   ,@ExpirationDate
                                   ,@IsActive
                                   ,@CreatedByUserID)

                        SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
        
            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                int ID = -1;

                if (Result != null && int .TryParse (Result .ToString(), out ID ))
                {
                    InsertedID = ID;
                }


            }
            catch
            {

            }
            connection.Close();

            return InsertedID;






        }


        public static DataTable GetListInternationalLicenses()
        {
            DataTable dtListInternationalLicenses = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT  InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate,ExpirationDate, IsActive
                            
                            From InternationalLicenses";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
               {
                   dtListInternationalLicenses.Load(reader);


               }

               reader.Close();

            }
            catch
            {

            }


            connection .Close();

            return dtListInternationalLicenses;

        }

        public static DataTable GetDriverLicenses(int DriverID)
        {
            DataTable dtListInternationalLicenses = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT  InternationalLicenseID, ApplicationID, IssuedUsingLocalLicenseID, IssueDate,ExpirationDate, IsActive
                            
                            From InternationalLicenses

                            WHERE DriverID = @DriverID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtListInternationalLicenses.Load(reader);


                }

                reader.Close();

            }
            catch
            {

            }


            connection.Close();

            return dtListInternationalLicenses;



        }

        public static bool IsDriverHaveActiveLicense(int DriverID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT FOUND = 1 FROM InternationalLicenses
                               WHERE DriverID = @DriverID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                
            }
            catch
            {

            }

            connection.Close();

            return IsFound;
        }


        public static DataTable LoadDriverInternationalLicenses(int DriverID)
        {
            DataTable dtListDriverLicenses = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            SELECT InternationalLicenseID
                                  ,ApplicationID
                                  ,IssuedUsingLocalLicenseID
                                  ,IssueDate
                                  ,ExpirationDate
                                  ,IsActive
    
                              FROM InternationalLicenses	
	
	                            WHERE DriverID = @DriverID

                            Order by InternationalLicenseID Desc;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    dtListDriverLicenses.Load(reader);


                }

            }
            catch
            {

            }

            return dtListDriverLicenses;


        }
    
    

    }
}
