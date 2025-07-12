using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsApplicationTypesDataAccess
    {
        public static DataTable GetAllApplicationTypes()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = " SELECT ApplicationTypeID AS ID, ApplicationTypeTitle AS [Application Type], ApplicationsFees AS [Fees] FROM ApplicationTypes";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dt = new DataTable();
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
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
            return dt;
        }
        public static bool GetApplicationType(ref int ID, ref string ApplicationType, ref decimal Fees)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ApplicationTypeID"];
                    ApplicationType = (string)reader["ApplicationTypeTitle"];
                    Fees = (decimal)reader["ApplicationFees"];

                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }
        public static bool UpdateApplicationType(
            int ID, string ApplicationType, decimal Fees
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE ApplicationTypes SET
                ApplicationTypeTitle = @ApplicationType,
                ApplicationFees = @Fees
                WHERE ApplicationTypeID = @ID
            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationType", ApplicationType);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@ID", ID);

            int rowsAffected = 0;
            bool result = false;
            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                result = (rowsAffected > 0);
            }
            catch (Exception ex)
            {
                result = false;
                clsErrorLog.AddErrorLog(ex);
                // Log
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

    }
}
