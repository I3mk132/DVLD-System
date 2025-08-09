using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsInternationalLicensesDataAccess
    {
        public static DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses";

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
            finally { connection.Close(); }

            return dt;
        }

        public static DataTable GetAllFor(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 
                                IL.InternationalLicenseID,    
                                IL.ApplicationID, 
                                ILC.ClassName, 
                                IL.IssueDate,
                                IL.ExpirationDate,
                                IL.IsActive
                            FROM InternationalLicenses IL 
                                JOIN Licenses L ON L.LicenseID = IL.IssuedUsingLocalLicenseID
                                JOIN LicenseClasses LC ON L.LicenseClassID = LC.LicenseClassID
                                JOIN Drivers D ON D.DriverID = IL.DriverID
                            WHERE D.PersonID = @PersonID";



            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
            finally { connection.Close(); }

            return dt;
        }

        public static int Add(
            int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, 
            DateTime? IssueDate, DateTime? ExpirationDate, bool IsActive, int CreatedByUserID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO Tests 
                (ApplicationID, DriverID, IssuedUsingLocalLicenseID, 
                IssueDate, ExpirationDate, IsActive, CreatedByUserID) Values 
                (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, 
                @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int ID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                    ID = id;

            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return ID;

        }

        public static bool Update(
            int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime? IssueDate, DateTime? ExpirationDate, bool IsActive, int CreatedByUserID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE InternationalLicenses SET
                ApplicationID = @ApplicationID,
                DriverID = @DriverID,
                IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                IssueDate = @IssueDate,
                ExpirationDate = @ExpirationDate,
                IsActive = @IsActive,
                CreatedByUserID = @CreatedByUserID,
                WHERE InternationalLicenseID = @InternationalLicenseID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


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

        public static bool Find(
            ref int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID,
            ref DateTime? IssueDate, ref DateTime? ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", InternationalLicenseID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime?)reader["IssueDate"];
                    ExpirationDate = (DateTime?)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                }

                reader.Close();
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

        public static bool Delete(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "DELETE InternationalLicenses WHERE InternationalLicenceID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;

        }
    }
}
