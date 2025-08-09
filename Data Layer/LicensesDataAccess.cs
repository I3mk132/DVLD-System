using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsLicensesDataAccess
    {
        public static DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Licenses";

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

        public static DataTable GetAllLocalFor(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);


            string query = @"SELECT 
                                L.LicenseID AS [License ID],    
                                L.ApplicationID AS [Application ID], 
                                LC.ClassName AS [Class Name], 
                                L.IssueDate AS [Issue Date],
                                L.ExpirationDate AS [Expiration Date],
                                L.IsActive AS [Is Active]
                            FROM Licenses L 
                                JOIN LicenseClasses LC ON L.LicenseClassID = LC.LicenseClassID
                                JOIN Drivers D ON D.DriverID = L.DriverID
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
            int ApplicationID, int DriverID, int LicenseClassID, DateTime? IssueDate, DateTime? ExpirationDate,
            string Notes, decimal PaidFees, bool? IsActive, string IssueReason, int CreatedByUserID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO Licenses 
                (ApplicationID, DriverID, LicenseClassID, IssueDate, 
                ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID) Values 
                (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, 
                @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (!string.IsNullOrEmpty(Notes))
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("Notes", DBNull.Value);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive.Value);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
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
            int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime? IssueDate, DateTime? ExpirationDate,
            string Notes, decimal PaidFees, bool? IsActive, string IssueReason, int CreatedByUserID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE Licenses SET
                ApplicationID = @ApplicationID,
                DriverID = @DriverID,
                LicenseClassID = @LicenseClassID,
                IssueDate = @IssueDate,
                ExpirationDate = @ExpirationDate,
                Notes = @Notes,
                PaidFees = @PaidFees,
                IsActive = @IsActive,
                IssueReason = @IssueReason,
                CreatedByUserID = @CreatedByUserID
                
                WHERE LicenseID = @ID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            if (!string.IsNullOrEmpty(Notes))
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive.Value);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ID", LicenseID);


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
            ref int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID, 
            ref DateTime? IssueDate, ref DateTime? ExpirationDate, ref string Notes, 
            ref decimal PaidFees, ref bool? IsActive, ref string IssueReason, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Licenses WHERE LicenseID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", LicenseID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    IssueDate = (DateTime?)reader["IssueDate"];
                    ExpirationDate = (DateTime?)reader["ExpirationDate"];
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool?)reader["IsActive"];
                    IssueReason = (string)reader["IssueReason"];
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
        public static bool FindByAppID(
            ref int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID,
            ref DateTime? IssueDate, ref DateTime? ExpirationDate, ref string Notes,
            ref decimal PaidFees, ref bool? IsActive, ref string IssueReason, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Licenses WHERE ApplicationID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ApplicationID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    IssueDate = (DateTime?)reader["IssueDate"];
                    ExpirationDate = (DateTime?)reader["ExpirationDate"];
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool?)reader["IsActive"];
                    IssueReason = (string)reader["IssueReason"];
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

            string query = "DELETE Licenses WHERE LicenseID = @ID";

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
