using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLDDataAccessLayer
{
    public class clsLicenseClassDataAccess
    {

        public static DataTable GetListLicenseClasses()
        {
            var dtListlicenseClasses = new DataTable();

            var connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM LicenseClasses";

            var command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtListlicenseClasses.Load(reader);

                }

            }
            catch
            {

            }
            return dtListlicenseClasses;

        }

        public static bool GetLicenseClassInfoByID(int LicenseClassID, ref string ClassName, ref string ClassDescription,
                                                   ref int MinimumAllowedAge, ref byte DefaultValidityLength, ref double ClassFees)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM LicenseClasses
                             
                             WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = (byte)(reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToDouble(reader["ClassFees"]);


                }
            }
            catch
            {
                IsFound = false;
            }

            return IsFound;

        }


        public static bool GetLicenseClassInfoByName(string ClassName, ref int LicenseClassID, ref string ClassDescription,
                                                  ref int MinimumAllowedAge, ref byte DefaultValidityLength, ref double ClassFees)
        {

            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM LicenseClasses
                             
                             WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    IsFound = true;

                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = (byte)(reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToDouble(reader["ClassFees"]);


                }
            }
            catch
            {
                IsFound = false;
            }

            return IsFound;

        }

    }
}
