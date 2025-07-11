using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsApplicationTypes
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
        public static bool UpdatePerson(
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
