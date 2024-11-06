using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLDDataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationDataAccess
    {

        public static bool GetLocalDrivingLicenseApplicationInfo(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications
                             
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];



                }

            }
            catch
            {
                IsFound = false;

            }
            connection.Close();

            return IsFound;
        }

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {

            int SelectedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
    
                              VALUES            (@ApplicationID, @LicenseClassID)

                              SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                int ID = 0;
                if (Result != null && int.TryParse(Result.ToString(), out ID))
                {
                    SelectedID = ID;

                }


            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return SelectedID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int LicenseClassID)
        {

            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Update LocalDrivingLicenseApplications 

                             SET LicenseClassID = @LicenseClassID

                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
        public static DataTable GetListLocalDrivingLicenseApplications()
        {
            DataTable dtListLocalDrivingLicenseApplications = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select * from localdrivingLicenseApplications_view ";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtListLocalDrivingLicenseApplications.Load(reader);


                }

                reader.Close();

            }
            catch
            {

            }
            finally
            {
                connection.Close();

            }

            return dtListLocalDrivingLicenseApplications;

        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE LocalDrivingLicenseApplications
                                WHERE  LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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

        public static bool IsLocalDrivingLicenseApplicationExisteByID(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT FOUND = 1 FROM  LocalDrivingLicenseApplications
                                WHERE  = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                reader.Close();
            }
            catch
            {
                IsFound = false;
            }

            connection.Close();

            return IsFound;

        }

        public static bool IsPersonHasAnotherLocalApplicationWithSameLicenseClass(int PersonID, int LicenseClassID)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT FOUND = 1 FROM LocalDrivingLicenseFullApplications_View
                             
                            WHERE ApplicantPersonID = @PersonID and LicenseClassID = @LicenseClassID and ( ApplicationStatus = 1 or ApplicationStatus = 3 ) ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                IsFound = reader.HasRows;

                reader.Close();

            }
            catch
            {
                IsFound = false;
            }


            connection.Close();

            return IsFound;
        }

        public static byte TotalTrilesPerTest(int LocalDrivingLiceneApplicationID, int TestTypeID)
        {

            byte TotalTriles = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @" SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                       ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLiceneApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                int Triels = 0;

                if (Result != null && int.TryParse(Result.ToString(), out Triels))
                {
                    TotalTriles = (byte)Triels;

                }

            }
            catch
            {

            }
            connection.Close();


            return TotalTriles;
        }

        public static bool DoesAttendTest(int LocalDrivingLicenseAplicationID, int TestTypeID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings .connectionString);

            string query = @"SELECT TOP 1 found = 1 from LocalDrivingLicenseApplications inner join
				                TestAppointments on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID inner join
				                Tests on TestAppointments .TestAppointmentID = Tests.TestAppointmentID
		                    WHERE (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseAplicationID ) 
				            AND   (TestAppointments.TestTypeID = @TestTypeID)
		                    ORDER BY TestAppointments.TestAppointmentID DESC ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseAplicationID", LocalDrivingLicenseAplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;


            }
            catch
            {
                //IsFound = false;

            }
            connection.Close();

            return IsFound;
        }

        public static bool DoesHaveUnlockedTest(int LocalDrivingLicenseApplication, int TestTypeID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM LocalDrivingLicenseApplications INNER JOIN TestAppointments
				                    ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                 			  WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplication AND TestAppointments.TestTypeID = @TestTypeID AND IsLocked = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplication", LocalDrivingLicenseApplication);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static bool DoesPassedTheTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT FOUND =1 FROM LocalDrivingLicenseApplications INNER JOIN TestAppointments 
					                   ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN Tests 
					                   ON TestAppointments .TestAppointmentID = tests.TestAppointmentID 

				        	WHERE ((LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID  = @LocalDrivingLicenseApplicationID) AND (TestAppointments.TestTypeID = @TestTypeID) AND (Tests.TestResult = 1)); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


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



    }
}
