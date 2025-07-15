using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsLicenseClassesDataAccess
    {
        public static List<string> GetAllLicenseClassNames()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT ClassName FROM LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            List<string> LicenseClasses = new List<string>();
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LicenseClasses.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return LicenseClasses;
        }

        public static int GetLicenseClassIDByName(string ClassName)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT LicenseClassID FROM LicenseClasses WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassName", ClassName);


            int LicenseClassID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    LicenseClassID = (int)result;
                }

            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return LicenseClassID;
        }
        public static string GetLicenseClassNameByID(int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT ClassName FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            string LicenseClassName = "";
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    LicenseClassName = (string)result;
                }

            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return LicenseClassName;
        }


    }
}
