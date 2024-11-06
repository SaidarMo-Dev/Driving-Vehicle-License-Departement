using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DVLDDataAccessLayer
{
    public class clsPeopleDataAccess
    {

        public static bool GetPersonByID(int PersonID, ref string NationalNo, ref string FirstName,
                                         ref string SecondName, ref string ThirdName, ref string LastName,
                                         ref DateTime DateOfBirth, ref byte Gendor, ref string Address,
                                         ref string Phone, ref string Email, ref int NationalityCountryID,
                                         ref string ImagePath)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                        ThirdName = "";

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                        Email = "";

                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                        ImagePath = "";


                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }
        public static bool GetPersonByNationalNo(string NationalNo, ref int PersonID, ref string FirstName,
                                    ref string SecondName, ref string ThirdName, ref string LastName,
                                    ref DateTime DateOfBirth, ref byte Gendor, ref string Address,
                                    ref string Phone, ref string Email, ref int NationalityCountryID,
                                    ref string ImagePath)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                        ThirdName = "";

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                        Email = "";

                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                        ImagePath = "";


                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }


        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName,
                                        string ThirdName, string LastName, DateTime DateOfBirth,
                                        byte Gendor, string Address, string Phone, string Email,
                                        int NationalityCountryID, string ImagePath)
        {

            int SelectedID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName,ThirdName, LastName, DateOfBirth,
                                                  Gendor, Address, Phone , Email, NationalityCountryID, ImagePath)
    
                              VALUES            (@NationalNo, @FirstName, @SecondName,@ThirdName, @LastName, @DateOfBirth,
                                                  @Gendor, @Address, @Phone , @Email, @NationalityCountryID, @ImagePath)
                              SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

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


        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName,
                                        string ThirdName, string LastName, DateTime DateOfBirth,
                                        byte Gendor, string Address, string Phone, string Email,
                                        int NationalityCountryID, string ImagePath)
        {

            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"UPDATE People

                              SET NationalNo = @NationalNo , FirstName = @FirstName , SecondName = @SecondName,
                                  ThirdName = @ThirdName,LastName = @LastName, DateOfBirth = @DateOfBirth,
                                  Gendor = @Gendor, Address = @Address, Phone = @Phone , Email =@Email, 
                                  NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath
                                  
                            WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath == "" || ImagePath == null)
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);


            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();

            return (rowsAffected > 0);

        }


        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"

                    EXEC SP_DeletePerson
	                    @PersonID = 1;
            ";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


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

    
        public static DataTable GetPeople()
        {
            DataTable dtListPeople = new DataTable();


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"
                           
                        EXEC SP_GetListPeople
	";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtListPeople.Load(reader);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dtListPeople;
        }


        public static bool IsPersonExisteByID(int PersonID)
        {

            bool IsPersonExiste = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT FOUND = 1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsPersonExiste = reader.HasRows;

                reader.Close();
            }
            catch
            {
                
                IsPersonExiste = false;

            }

            connection.Close();

            return IsPersonExiste;
        }

        public static bool IsPersonExisteNationalNo(string NationalNo)
        {

            bool IsPersonExiste = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT FOUND = 1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsPersonExiste = reader .HasRows;

                
                reader.Close();
                connection.Close();

            }
            catch
            {
                IsPersonExiste = false;
            }
           

            return IsPersonExiste;
        }


        public static string GetPersonImagePath(int PersonID)
        {

            string ImagePath = "";
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT ImagePath From People 
                                WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                   
                }

                reader.Close();
            }
            catch
            {

                ImagePath = "";
            }

            connection.Close();

            return ImagePath ;
        }

        static void Main(string[] args)
        {
        }

    }

}
