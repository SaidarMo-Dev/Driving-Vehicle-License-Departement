using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DVLDDataAccessLayer
{
    public class clsDriverDataAccess
    {
        public static bool GetDriverInfoByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate )
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Drivers 
                              WHERE    DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {

                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                  

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

        public static bool GetDriverInfoByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Drivers 
                              WHERE    PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())
                {

                    IsFound = true;

                    DriverID = (int)reader["DriverID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];


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
       
        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int InsertedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            
                            INSERT INTO Drivers
                                       (PersonID
                                       ,CreatedByUserID
                                       ,CreatedDate)
                                 VALUES
                                       (@PersonID
                                       ,@CreatedByUserID
                                       ,@CreatedDate)

                            SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
         

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                int ID = -1;

                if (Result != null && int.TryParse(Result.ToString(), out ID))
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


        public static DataTable GetAllDrivers()
        {


            DataTable dtListDrivers = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"


                            select Drivers.DriverID, Drivers.PersonID, People.NationalNo , 
	                              (people .FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName ) AS FullName ,
		                            Drivers.CreatedDate from drivers inner join People 
			                            ON Drivers.PersonID = People.PersonID;
    ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    dtListDrivers.Load(reader);

                }

                reader.Close();

            }
            catch
            {
                
            }

            connection.Close();

            return dtListDrivers;

        }
  
        public static bool IsPersonAlreadyDriver(int PersonID)
        {
            
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Drivers 
                               WHERE PersonID = @PersonID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
