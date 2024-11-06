using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLDDataAccessLayer
{
    public class clsApplicationsDataAccess
    {


        public static bool GetApplicationInfoByID(int ApplicationID, ref int ApplicationPersonID, ref DateTime  ApplicationDate, ref int ApplicationTypeID,
                                                   ref byte ApplicationStatus, ref DateTime LastStatusDate, ref double ApplicationPaidFees, ref int CreatedByUserID)

        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * from Applications 
                               WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    ApplicationPaidFees = Convert.ToDouble (reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }
                else
                    IsFound = false;

                reader.Close();

            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();

            }

            return IsFound;

        }


        public static int AddNewApplication(int AppPersonID, DateTime AppDate, int AppTypeID, int AppStatus,
                                               DateTime LastStatusDate, double AppPaidFees, int CreatedByUserID)
        {

            int SelectedApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID,ApplicationStatus,
                                                        LastStatusDate, PaidFees, CreatedByUserID)
    
                              VALUES            (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus,
                                                        @LastStatusDate, @PaidFees, @CreatedByUserID)

                              SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", AppPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", AppDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", AppTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", AppPaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

         
            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                int ID = 0;
                if (Result != null && int.TryParse(Result.ToString(), out ID))
                {
                    SelectedApplicationID = ID;

                }


            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return SelectedApplicationID;
        }


        public static bool UpdateApplication(int ApplicationID, int AppPersonID, DateTime  AppDate, int AppTypeID, byte AppStatus,
                                                DateTime LastStatusDate, double AppPaidFees, int CreatedByUserID)
        {
            

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Applications 
                               SET     ApplicantPersonID = @ApplicationPersonID, 
                                       ApplicationDate = @ApplicationDate,            
                                       ApplicationTypeID = @ApplicationTypeID,
                                       ApplicationStatus = @ApplicationStatus,
                                       LastStatusDate = @LastStatusDate,
                                       PaidFees = @PaidFees,
                                       CreatedByUserID = @CreatedByUserID
                            WHERE ApplicationID = @AppID;                         
        ";
                                  


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationPersonID", AppPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", AppDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", AppTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", AppPaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@AppID", ApplicationID);


            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

                

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0) ;
        }

        public static bool DeleteApplication(int ApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE Applications
                                WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

    
            }
            catch
            {
               
            }
            finally
            {
                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static bool IsApplicationExiste(int ApplicationID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Applications 
                                WHERE  ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", ApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                }
                else
                    IsFound = false;


                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }

            connection.Close();

            return IsFound;
            }

        public static DataTable GetAllApplications()
        {
            DataTable dtListApplications = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Applications";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader .HasRows )
                {
                    dtListApplications.Load(reader);

                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();

            }

            return dtListApplications;

        }

        public static bool UpdateApplicationStatus(int ApplicationID, byte ApplicationStatus)
        {
            
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Applications 
                               SET    
                                       ApplicationStatus = @ApplicationStatus
                      
                            WHERE ApplicationID = @ApplicationID;                         
        ";
                                  


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

                

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }




        }

}
