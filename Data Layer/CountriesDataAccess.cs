using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsCountriesDataAccess
    {

        public static List<string> GetAllCountries()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT CountryName FROM Countries";

            SqlCommand command = new SqlCommand(query, connection);

            List<string> Countries = new List<string>();
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Countries.Add(reader.GetString(0));
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
            return Countries;
        }
        public static int GetCountryIDByName(string CountryName)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT CountryID FROM Countries WHERE CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);


            int CountryID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    CountryID = (int)result;
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
            return CountryID;
        }
        public static string GetCountryNameByID(int CountryID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT CountryName FROM Countries WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);


            string CountryName = "";
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    CountryName = (string)result;
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
            return CountryName;
        }

    }
}
