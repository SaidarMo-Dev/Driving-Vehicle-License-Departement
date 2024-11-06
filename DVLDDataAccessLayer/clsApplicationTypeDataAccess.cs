using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DVLDDataAccessLayer
{


    public class clsApplicationTypeDataAccess
    {

        public static bool GetApplicationType(int ID, ref string AppTypeTitle, ref double Fees)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT *  FROM ApplicationTypes
                                WHERE ApplicationTypeID = @ID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read ())
                {

                    IsFound = true;

                    AppTypeTitle = (string)reader["ApplicationTypeTitle"];
                    Fees = Convert .ToDouble(reader["ApplicationFees"]);

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

        public static bool UpdateApplicationTypes(int ID ,string AppTypeTitle, double AppFees)
        {
            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE ApplicationTypes
                             SET    ApplicationTypeTitle = @Title,
                                    ApplicationFees  = @Fees
                            WHERE   ApplicationTypeID = @ID ;";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", AppTypeTitle);
            command.Parameters.AddWithValue("@Fees", AppFees);
            command.Parameters.AddWithValue("@ID", ID );


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


        public static DataTable GetListApplicationTypes()
        {
            DataTable dtappTypes = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM ApplicationTypes";

            SqlCommand command = new SqlCommand(query,connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader .HasRows)
                {
                    dtappTypes.Load(reader);
                }

                reader.Close();
            }
            catch
            {

            }

            connection.Close();

            return dtappTypes;

        }


    }
}
