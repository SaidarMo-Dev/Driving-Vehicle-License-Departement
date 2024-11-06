using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLDDataAccessLayer
{
    public class TestAppointementDataAccess
    {
        public static bool GetTestAppointementInfo(int TestAppointementID, ref int TestTypeID,ref int LocalDrivingLicenseApplicationID,
                                                     ref DateTime AppointementDate, ref double AppointementFees,ref int CreatedByUserID,
                                                    ref bool IsLocked, ref int RetakeTestApplicationID )
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM TestAppointments 
                             WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointementID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read ())
                {
                    IsFound = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointementDate = (DateTime)reader["AppointmentDate"];
                    AppointementFees = Convert.ToDouble(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];

                    RetakeTestApplicationID = ((reader["RetakeTestApplicationID"] != DBNull.Value) ? (int)reader["RetakeTestApplicationID"] : -1); 
                    
                 

                }

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


        public static int AddNewTestAppointement(int TestTypeID,int LocalDrivingLicenseApplicationID,
                                                  DateTime AppointementDate,double AppointementFees,
                                                  int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {

            int InsertedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID )
                              VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID )

                            SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointementDate);
            command.Parameters.AddWithValue("@PaidFees", AppointementFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", (IsLocked) ? 1 : 0);
            if (RetakeTestApplicationID == -1)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }

            

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                int ID = -1;
                
                if (result != null && int.TryParse(result.ToString(), out ID))
                {
                    InsertedID = ID;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);

            }

            connection.Close();

            return InsertedID;
       
        }


        public static bool UpdateTestAppointement(int TestAppointementID, int TestTypeID,int LocalDrivingLicenseApplicationID,
                                                  DateTime AppointementDate,double AppointementFees,
                                                  int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)

          {
              int rowsAffected = 0;


              SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

              string query = @"UPDATE TestAppointements 
                               
                             SET  TestTypeID = @TestTypeID,
                                  LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                  AppointementDate = @AppointementDate, 
                                  PaidFees = PaidFees,
                                  CreatedByUserID = @CreatedByUserID,
                                  IsLocked = @IsLocked,
                                  RetakeTestApplicationID = @RetakeTestApplicationID
                          
                            WHERE TestAppointementID = @TestAppointementID;

                             ";

              SqlCommand command = new SqlCommand(query, connection);


              command.Parameters.AddWithValue("@TestAppointementID", TestAppointementID);
              command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
              command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
              command.Parameters.AddWithValue("@AppointementDate", AppointementDate);
              command.Parameters.AddWithValue("@PaidFees", AppointementFees);
              command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
              command.Parameters.AddWithValue("@IsLocked", (IsLocked) ? 1 : 0);
              if (RetakeTestApplicationID == -1)
              {
                  command.Parameters.AddWithValue("@RetakeTestApplicationID", SqlDbType.Int).Value = DBNull.Value;
              }
              else
              {
                  command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
              }

            
              try
              {
                  connection.Open();

                  rowsAffected = command.ExecuteNonQuery();



              }
              catch 
              {

              }

              connection.Close();


              return (rowsAffected > 0);


          }
        
        public static DataTable GetAllTestAppointementsWithinTheTestType(int LocalApplicationID, int TestTypeID)
        {
            DataTable dtTestApointements = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TestAppointmentID, AppointmentDate,PaidFees, IsLocked
                             FROM TestAppointments
                             WHERE  
                            (TestTypeID = @TestTypeID) 
                            AND (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                            order by TestAppointmentID desc;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtTestApointements.Load(reader);

                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();

            }

            return dtTestApointements;


        }








    }
}
