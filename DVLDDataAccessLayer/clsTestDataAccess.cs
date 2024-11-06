using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient ;
using System.Data ;
namespace DVLDDataAccessLayer
{
    public class clsTestDataAccess
    {
        public static bool GetTestInfoByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Tests
                             WHERE TestID = @TestID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read ())
                {
                    IsFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = ((int)reader["TestResult"] == 1) ? true :false ;
                    Notes = (string)reader["Notes"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }

                reader.Close();
            }
            catch
            {
                IsFound = false;
            }

            connection.Close();

            return IsFound;
        }

        public static int AddNewTest(int TestApponintmentID, bool TestResult,string Notes, int CreatedByUserID )
        {
            int InsertedTestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            INSERT INTO Tests
                                       (TestAppointmentID
                                       ,TestResult
                                       ,Notes
                                       ,CreatedByUserID)
                                 VALUES
                                       (@TestAppointmentID
                                       ,@TestResult
                                       ,@Notes
                                       ,@CreatedByUserID)

                        UPDATE TestAppointments 
                                SET IsLocked=1 where TestAppointmentID = @TestAppointmentID;
    
                                SELECT SCOPE_IDENTITY(); 
";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestApponintmentID);
            command.Parameters.AddWithValue("@TestResult", (TestResult) ? 1 : 0);
            if (Notes != "" && Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
          
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
        
            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                int ID = 0;

                if (Result != null && int.TryParse(Result.ToString (), out ID))
                {
                    InsertedTestID = ID;
                }

            }
            catch
            {

            }
            connection.Close();

            return InsertedTestID;

        }

        public static bool UpdateTest(int TestID, int TestApponintmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int  RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            
                            UPDATE Tests
                               SET TestAppointmentID = @TestAppointmentID
                                  ,TestResult = @TestResult
                                  ,Notes = @Notes
                                  ,CreatedByUserID = @CreatedByUserID
                             WHERE TestID = @TestID ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestApponintmentID);
            command.Parameters.AddWithValue("@TestResult", (TestResult )? 1:0);
            command.Parameters.AddWithValue("@Notes", (string.IsNullOrEmpty(Notes))? (object)DBNull.Value : Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@TestID", TestID);


            try
            {

                RowsAffected = command.ExecuteNonQuery();

            }
            catch
            {

            }
            connection.Close();

            return ( RowsAffected > 0 );

        }
  
        public static byte PassedTests(int LocalDrivingLicenseApplicationID)
        {
            byte CountPassedTests = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            SELECT count(TestTypeID) AS PassedTests FROM Tests INNER JOIN TestAppointments 
		                            ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
	                        
                            WHERE (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and tests.TestResult = 1); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                int PassedTests = 0;

                if (Result != null && int.TryParse (Result .ToString(),out PassedTests))
                {
                    CountPassedTests = (byte)PassedTests;
                }
            }
            catch
            {

            }

            connection.Close();

            return CountPassedTests;
        }
    

    }
}
