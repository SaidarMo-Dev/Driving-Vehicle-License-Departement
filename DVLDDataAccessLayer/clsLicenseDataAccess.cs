using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DVLDDataAccessLayer
{
    public class clsLicenseDataAccess
    {
        public static bool GetLicenseInfoByLicenseID(int LicenseID, ref  int ApplicationID, ref int DriverID,
                      ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate, 
                      ref string Notes, ref double PaidFees, ref bool IsActive , ref byte IssueReason,
                    ref int CreatedByUserID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Licenses 
                              WHERE    LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read()) 
                {

                    IsFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClassID =(int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    PaidFees = Convert.ToDouble( reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID  = (int)reader["CreatedByUserID"];



                }
            }
            catch
            {
                IsFound = false;
            }

            connection.Close();

            return IsFound;

        }

        public static bool GetLicenseInfoByApplicationID(int ApplicationID, ref  int LicenseID, ref int DriverID,
                  ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate,
                  ref string Notes, ref double PaidFees, ref bool IsActive, ref byte IssueReason,
                ref int CreatedByUserID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Licenses 
                              WHERE    ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {

                    IsFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClassID = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    IsActive = (Convert .ToInt16(reader["IsActive"]) == 1) ? true : false;
                   // if ((int)reader["IsActive"] == 1)
                   // {

                   //     IsActive = true;
                   // }
                   // else
                   //     IsActive = false;

                    IssueReason = (byte)reader["IssueReason"];
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


        public static int AddNewLicense(int ApplicationID, int DriverID,
                      int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, 
                      string Notes, double PaidFees, bool IsActive , byte IssueReason,
                      int CreatedByUserID)
        {

            int InsertedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            INSERT INTO Licenses
                                       (ApplicationID
                                        ,DriverID
                                        ,LicenseClass
                                        ,IssueDate
                                        ,ExpirationDate
                                        ,Notes
                                        ,PaidFees
                                        ,IsActive
                                        ,IssueReason
                                        ,CreatedByUserID)
                                 VALUES
                                      (@ApplicationID
                                       ,@DriverID
                                       ,@LicenseClass
                                       ,@IssueDate
                                       ,@ExpirationDate
                                       ,@Notes
                                       ,@PaidFees
                                       ,@IsActive
                                       ,@IssueReason
                                       ,@CreatedByUserID);

                            SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (Notes == "")
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
                
            else
                 command.Parameters.AddWithValue("@Notes",  Notes);

            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                int ID = -1;

                if (Result != null && int.TryParse (Result .ToString (), out ID ))
                {
                    InsertedID = ID ;
                }
            }
            catch
            {

            }
            connection.Close ();


            return InsertedID ;
        }
   
    
        public static bool IsLicenseExisteByLicenseID(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Licenses 
                               WHERE LicenseID = @LicenseID ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool IsLicenseExisteByApplicationID(int ApplicationID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Licenses 
                               WHERE ApplicationID = @ApplicationID ";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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



        public static DataTable LoadDriverLicenses(int DriverID)
        {
            DataTable dtListDriverLicenses = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT LicenseID, ApplicationID,  ClassName,issueDate, ExpirationDate, IsActive 
                            
                            From Licenses Inner Join LicenseClasses
                                           ON Licenses.LicenseClass = LicenseClasses.LicenseClassID	
	
	                            WHERE Licenses.DriverID = @DriverID
    
                             Order by LicenseID Desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader .HasRows )
                {
                    dtListDriverLicenses.Load(reader);


                }

            }
            catch
            {

            }

            return dtListDriverLicenses;


        }
    
    
        public static int GetActiveLicenseID(int ApplicationID)
        {

            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT LicenseID FROM Licenses
                                
                              WHERE ApplicationID = @ApplicationID AND IsActive = 1;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader .Read())
                {
                    LicenseID = (int)reader["LicenseID"];


                }
            }
            catch
            {

            }

            connection.Close();

            return LicenseID;
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Licenses
                                
                              WHERE LicenseID = @LicenseID AND IsActive = 1;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    IsFound = true;

                }
            }
            catch
            {
                
            }

            connection.Close();

            return IsFound;
        }

        public static int GetDriverID(int LicenseID)
        {
            
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT DriverID FROM Licenses
                                
                              WHERE LicenseID = @LicenseID;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    DriverID = (int)reader["DriverID"];
                }
            }
            catch
            {
                
            }

            connection.Close();

            return DriverID;
        }

        public static bool ReactivateLicense(int LicenseID)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            UPDATE Licenses
	                            SET IsActive = 1

	                            where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();



            }
            catch
            {

            }

            connection.Close();

            return (RowsAffected > 0);


        }

        

        public static bool DeactivateLicense(int LicenseID)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            UPDATE Licenses
	                            SET IsActive = 0

	                            where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();



            }
            catch
            {

            }

            connection.Close();

            return (RowsAffected > 0);


        }

        
    }
}
