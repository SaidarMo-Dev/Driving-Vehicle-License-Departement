using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLDDataAccessLayer
{

    public class clsUserDataAccess
    {
        public static bool GetUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive =(bool)reader["IsActive"];

                }
                else
                    IsFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


        public static bool GetUserByUsername(string Username, ref int UserID,ref int PersonID,
                                              ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Users WHERE UserName = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

                }
                else
                    IsFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        public static bool GetUserByUsernameAndPassword(string Username, string Password,ref int UserID ,ref int PersonID, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Users WHERE (UserName = @Username AND Password = @Password)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);



            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];

                }
                else
                    IsFound = false;

                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {

            int InsertedID =-1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive)
                              VALUES (@PersonID, @UserName, @Password,@IsActive)

                            SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", (IsActive) ? 1: 0);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                int ID =-1;
                if (result != null && int.TryParse(result.ToString (), out ID))
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
     
        public static bool UpdateUser(int ID, int PersonID, string Username, string Password, bool IsActive)
        {
            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Users 

                              SET   PersonID = @PersonID,
                                    UserName = @Username,
                                    Password = @Password,
                                    IsActive = @IsActive
                              WHERE UserID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive ? 1:0);
            command.Parameters.AddWithValue("@ID", ID);

           
            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                

                
            }
            catch (Exception ex)
            {

            }

            connection.Close();

         
            return (rowsAffected > 0);

        }

        public static bool DeleteUser(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete Users
                                   WHERE UserID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();

            }

            return (rowsAffected > 0);

        }
        public static bool IsUserExisteByID(int ID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT FOUND = 1 FROM Users WHERE UserID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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

        public static bool IsUserExisteByUsername(string Username)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT FOUND = 1 FROM Users WHERE UserName = @Username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);

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

        public static DataTable GetAllUsers()
        {
            DataTable dtListUsers = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                            SELECT Users.UserID, Users.UserName,
		                            (SELECT people.FirstName +' '+ people.SecondName + ' ' + people.ThirdName
		                              FROM people 
		                                WHERE people .PersonID = Users .PersonID) AS FullName,
                                    Users.IsActive 
                            FROM Users";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtListUsers.Load(reader);
                }

                reader.Close();
            }


            catch
            {

            }

            return dtListUsers;

        }

        public static bool IsPersonHaveUser(int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
         
            string query = "SELECT FOUND = 1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
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
        


    }
}