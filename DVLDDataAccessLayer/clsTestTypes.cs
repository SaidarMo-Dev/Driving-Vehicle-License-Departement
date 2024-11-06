using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLDDataAccessLayer
{
    public class clsTestTypes
    {
        public static bool GetTestType(int TestTypeID, ref string Title, ref string Description , ref double Fees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM TestTypes 
                             WHERE TestTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader .Read ())
                {
                    IsFound = true;
                    Title = (string)reader["TestTypeTitle"];
                    Description = (string)reader["TestTypeDescription"];
                    Fees = Convert.ToDouble(reader["TestTypeFees"]);

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

        public static DataTable GetListTestTypes()
        {

            DataTable dtListTestTypes = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM TestTypes";

            SqlCommand command = new SqlCommand(query, connection);
           
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtListTestTypes.Load(reader);
                }

                reader.Close();
            }
            catch
            {

            }

            connection.Close();

            return dtListTestTypes;

        }
    
        public static bool UpdateTestType(int TestTypeID , string Title ,string Description , double Fees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE TestTypes 
                             SET    TestTypeTitle       = @Title,
                                    TestTypeDescription = @Description,
                                    TestTypeFees        = @Fees 
                           
                            WHERE TestTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", TestTypeID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);

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
    
    
    }
}
