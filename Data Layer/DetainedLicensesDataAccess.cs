using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsDetainedLicensesDataAccess
    {
        public static DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"
                SELECT 
                    DL.DetainID AS [Detain ID],  
                    DL.LicenseID AS [License ID],
					DL.DetainDate AS [Detain Date],
					DL.IsReleased AS [Is Released],
					DL.FineFees AS [Fine Fees],
					DL.ReleaseDate AS [Release Date],
					P.NationalNo AS [National No.],
					P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname AS [Full Name],
					DL.ReleaseApplicationID AS [Release App. ID]

                FROM DetainedLicenses DL 
                    JOIN Licenses L ON L.LicenseID = DL.LicenseID
                    JOIN Drivers D ON D.DriverID = L.DriverID
                    JOIN Person P ON P.PersonID = D.PersonID
                    
            ";

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
        public static DataTable GetAllFiltered(
            int DetainID = -1, bool? IsReleased = null, string NationalNo = "", string Fullname = "", int ReleaseApplicationID = -1)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"
                SELECT 
                    DL.DetainID AS [Detain ID],  
                    DL.LicenseID AS [License ID],
					DL.DetainDate AS [Detain Date],
					DL.IsReleased AS [Is Released],
					DL.FineFees AS [Fine Fees],
					DL.ReleaseDate AS [Release Date],
					P.NationalNo AS [National No.],
					P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname AS [Full Name],
					DL.ReleaseApplicationID AS [Release App. ID]

                FROM DetainedLicenses DL 
                    JOIN Licenses L ON L.LicenseID = DL.LicenseID
                    JOIN Drivers D ON D.DriverID = L.DriverID
                    JOIN Person P ON P.PersonID = D.PersonID
                WHERE 
                    (@DetainID IS NULL OR 
                    DL.DetainID = @DetainID) AND

                    (@IsReleased IS NULL OR 
                    DL.IsReleased = @IsReleased) AND

					(@NationalNo IS NULL OR
					P.NationalNo LIKE '%' + @NationalNo + '%') AND

                    (@Fullname IS NULL OR 
                        P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname LIKE '%' + @Fullname + '%') AND

					(@ReleaseApplicationID IS NULL OR
					DL.ReleaseApplicationID = @ReleaseApplicationID)

            ";

            
            SqlCommand command = new SqlCommand(query, connection);

            if (DetainID != -1)
                command.Parameters.AddWithValue("@DetainID", DetainID);
            else
                command.Parameters.AddWithValue("@DetainID", DBNull.Value);

            if (IsReleased != null)
                command.Parameters.AddWithValue("@IsReleased", IsReleased);
            else
                command.Parameters.AddWithValue("@IsReleased", DBNull.Value);

            if (!string.IsNullOrEmpty(NationalNo))
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
            else
                command.Parameters.AddWithValue("@NationalNo", DBNull.Value);

            if (!string.IsNullOrEmpty(Fullname))
                command.Parameters.AddWithValue("@Fullname", Fullname);
            else
                command.Parameters.AddWithValue("@Fullname", DBNull.Value);

            if (ReleaseApplicationID != -1)
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);

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
            int LicenseID, DateTime? DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased,
            DateTime? ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO DetainedLicenses 
                (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, 
                ReleasedByUserID, ReleaseApplicationID) Values 
                (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, 
                @ReleasedByUserID, @ReleaseApplicationID);
                SELECT SCOPE_IDENTITY();

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (ReleaseDate.HasValue)
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

            if (ReleasedByUserID != -1)
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

            if (ReleaseApplicationID != -1)
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);


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
            int DetainID, int LicenseID, DateTime? DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased,
            DateTime? ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE DetainedLicenses SET
                LicenseID = @LicenseID,
                DetainDate = @DetainDate,
                FineFees = @FineFees,
                CreatedByUserID = @CreatedByUserID,
                IsReleased = @IsReleased,
                ReleaseDate = @ReleaseDate,
                ReleasedByUserID = @ReleasedByUserID,
                ReleaseApplicationID = @ReleaseApplicationID
                WHERE DetainID = @DetainID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            if (ReleaseDate.HasValue)
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            else
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

            if (ReleasedByUserID != -1)
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);

            if (ReleaseApplicationID != -1)
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            command.Parameters.AddWithValue("@DetainID", DetainID);


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
            ref int DetainID, ref int LicenseID, ref DateTime? DetainDate, ref decimal FineFees, 
            ref int CreatedByUserID, ref bool IsReleased,
            ref DateTime? ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM DetainedLicenses WHERE DetianID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", DetainID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime?)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime?)reader["ReleaseDate"];
                    else
                        ReleaseDate = null;

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = -1;

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = -1;


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
        public static bool FindByLicenseID(
            ref int DetainID, ref int LicenseID, ref DateTime? DetainDate, ref decimal FineFees,
            ref int CreatedByUserID, ref bool IsReleased,
            ref DateTime? ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT top 1 * FROM DetainedLicenses WHERE LicenseID = @ID ORDER BY DetainID DESC";

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

                    DetainID = (int)reader["DetainID"];
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime?)reader["DetainDate"];
                    FineFees = (decimal)reader["FineFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];
                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime?)reader["ReleaseDate"];
                    else
                        ReleaseDate = null;

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];
                    else
                        ReleasedByUserID = -1;

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                    else
                        ReleaseApplicationID = -1;


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

            string query = "DELETE DetainedLicenses WHERE DetainID = @ID";

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

        public static bool IsLicenseDetained(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                SELECT 1 
                FROM DetainedLicenses
                WHERE LicenseID = @LicenseID AND IsReleased = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            bool IsFound = false;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;

        }
        public static DataTable LicenseDetainHistory(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT DetainDate, FineFees, ReleaseDate, ReleasedByUserID FROM DetainedLicenses WHERE LicenseID = @LicenseID";

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
    }
}
