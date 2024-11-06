using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data ;

namespace DVLDDataAccessLayer
{
    public class clsDetainedLicenseDataAccess
    {

        public static bool GetDetainedLicenseInfoByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate,
                        ref double FineFees, ref int CreatedByUserID, ref bool IsReleased,
                        ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Select * FROM DetainedLicenses 
                               Where DetainID = @DetainID AND IsReleased = 0
                            ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader .Read ())
                {
                    IsFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToDouble(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];




                }

                reader.Close();

                
            }
            catch
            {

            }


            connection.Close();

            return IsFound;

        }
        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate,
                      ref double FineFees, ref int CreatedByUserID, ref bool IsReleased,
                      ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Select * FROM DetainedLicenses 
                               Where LicenseID = @LicenseID AND IsReleased = 0 ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToDouble(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];




                }

                reader.Close();


            }
            catch
            {

            }


            connection.Close();

            return IsFound;

        }



        public static int AddDetainedLicenseInfo( int LicenseID, DateTime DetainDate,
                      double FineFees, int CreatedByUSerID)
        {

            int InsertedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"

                            INSERT INTO DetainedLicenses
			                            (
                                        LicenseID
                                       ,DetainDate
                                       ,FineFees
                                       ,CreatedByUserID
                                       ,IsReleased

                                       )
                                 VALUES
                                       (
                                        @LicenseID
                                       ,@DetainDate
                                       ,@FineFees
                                       ,@CreatedByUserID
                                       ,@IsReleased
                                       )

                                SELECT SCOPE_IDENTITY();

";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUSerID);
            command.Parameters.AddWithValue("@IsReleased", false);


            try
            {
                connection.Open();

               object Result = command.ExecuteScalar();

                int ID = -1;

                if (Result != null && int .TryParse(Result .ToString(), out ID))

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


        public static bool UpdateDetainedLicenseInfo(int DetainID, DateTime ReleaseDate,
                             int ReleasedByUserID, int ReleaseApplicationID)
        {

            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"

                            Update DetainedLicenses
			                         
                                 SET  IsReleased = 1
                                      ,ReleaseDate = @ReleaseDate
                                      ,ReleasedByUserID = @ReleasedByUserID
                                      ,ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID;

                             ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);


            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();





            }
            catch
            {

            }


            connection.Close();

            return (RowsAffected > 0 );

        }
   
    
        public static bool IsLicenseDetained(int LicenseID)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT FOUND = 1 From DetainedLicenses
                             Where  LicenseID = @LicenseID AND IsReleased = 0   ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@licenseID", LicenseID);

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
    

        public static DataTable GetListDetainedLicenses()
        {
            DataTable dtListDetainedLicensees = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"  


                        select DetainedLicenses .DetainID , DetainedLicenses.LicenseID, DetainedLicenses.DetainDate 
		                        ,DetainedLicenses.FineFees, DetainedLicenses.IsReleased, DetainedLicenses.ReleaseDate ,People .NationalNo
		                        ,(people .FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName ) AS FullName  
		                        ,DetainedLicenses.ReleaseApplicationID 

                        from DetainedLicenses inner Join Licenses 
					                        ON DetainedLicenses.LicenseID = Licenses.LicenseID inner join Drivers 
					                        ON Licenses.DriverID = Drivers.DriverID inner join People 
					                        ON Drivers.PersonID = People .PersonID;

";

            SqlCommand command = new SqlCommand(query, connection);

           
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader .HasRows)
                {
                    dtListDetainedLicensees.Load(reader);
                }


            }
            catch
            {

            }

            connection.Close();

            return dtListDetainedLicensees;



        }
    



    }
}
