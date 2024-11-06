using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DVLDDataAccessLayer
{
    public class clsCountryDataAccess
    {
        public static bool GetCountryInfoByID(int CountryID, ref string CountryName)
       {
           SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

           string query = "Select * from Countries where CountryID = @CountryID";
            
           SqlCommand command = new SqlCommand (query, connection );

           command.Parameters.AddWithValue("@CountryID", CountryID );

           bool IsFound = false;

           try
           {
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               if (reader.Read())
               {
                   IsFound = true;
                 
                   CountryName = (string)reader["CountryName"];
                  

               }
               else
                   IsFound = false;

           }
           catch (Exception ex)
           {
              // Console.WriteLine("error"+ ex.Message );
               IsFound = false;

           }
           finally
           {

               connection.Close();
           }

           return IsFound;
       }

        public static bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ID = (int)reader["CountryID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetListCountries()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Countries order by CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable ListCoutries = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    ListCoutries.Load(reader);
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

            return ListCoutries;
        }


    }
}
