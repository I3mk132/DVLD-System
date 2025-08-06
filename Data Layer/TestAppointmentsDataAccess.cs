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
    public class clsTestAppointmentsDataAccess
    {
        public static DataTable GetAllFor(int LDLAppID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 
                                TestAppointmentID AS [Appointment ID], 
                                AppointmentDate AS [Appointment Date], 
                                PaidFees AS [Paid Fees], 
                                IsLocked AS [Is Locked] 
                                FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @ID AND TestTypeID = @TTID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", LDLAppID);
            command.Parameters.AddWithValue("@TTID", TestTypeID);

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
            int TestTypeID, int LDLAppID, DateTime? AppointmentDate, decimal PaidFees, int CreatedByUserID,
            bool? IsLocked, int RetakeTestAppointmentID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO TestAppointments 
                (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID) Values 
                (@TestTypeID, @LDLAppID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestAppointmentID);
                SELECT SCOPE_IDENTITY();

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked.Value);
            if (RetakeTestAppointmentID != -1)
                command.Parameters.AddWithValue("@RetakeTestAppointmentID", RetakeTestAppointmentID);
            else
                command.Parameters.AddWithValue("@RetakeTestAppointmentID", DBNull.Value);


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
            int TestAppointmentID, int TestTypeID, int LDLAppID, DateTime? AppointmentDate, 
            decimal PaidFees, int CreatedByUserID, bool? IsLocked, int RetakeTestAppointmentID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE TestAppointments SET
                TestTypeID = @TestType,
                LocalDrivingLicenseApplicationID = @LDLAppID,
                AppointmentDate = @AppointmentDate,
                PaidFees = @PaidFees,
                CreatedByUserID = @CreatedByUserID,
                IsLocked = @IsLocked,
                RetakeTestAppointmentID = @RetakeTestAppointmentID
                WHERE TestAppointmentID = @ID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked.Value);
            if (RetakeTestAppointmentID != -1)
                command.Parameters.AddWithValue("@RetakeTestAppointmentID", RetakeTestAppointmentID);
            else
                command.Parameters.AddWithValue("@RetakeTestAppointmentID", DBNull.Value);
            command.Parameters.AddWithValue("@ID", TestAppointmentID);

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
            ref int TestAppointmentID, ref int TestTypeID, ref int LDLAppID, 
            ref DateTime? AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID,
            ref bool? IsLocked, ref int RetakeTestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", TestAppointmentID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    LDLAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime?)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool?)reader["IsLocked"];
                    if (reader["RetakeTestAppointmentID"] != DBNull.Value)
                        RetakeTestAppointmentID = (int)reader["RetakeTestAppointmentID"];
                    else
                        RetakeTestAppointmentID = -1;

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
        public static bool FindUsingLDLAppID(
            ref int TestAppointmentID, ref int TestTypeID, ref int LDLAppID,
            ref DateTime? AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID,
            ref bool? IsLocked, ref int RetakeTestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", LDLAppID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestTypeID = (int)reader["TestTypeID"];
                    LDLAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime?)reader["AppointmentDateID"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool?)reader["IsLocked"];
                    if (reader["RetakeTestAppointmentID"] != null)
                        RetakeTestAppointmentID = (int)reader["RetakeTestAppointmentID"];
                    else
                        RetakeTestAppointmentID = -1;

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

        public static int IsRetakeAppointment(int LDLAppID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT AppointmentID FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LDLAID AND TestTypeID = @TTID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAID", LDLAppID);
            command.Parameters.AddWithValue("@TTID", TestTypeID); 

            int ID = -1;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                    ID = (int)result;
                    
            } 
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog (ex);
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public static bool CheckForUnlockedTest(int LDLAppID, int TestTypeID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT 1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LDLAID AND TestTypeID = @TTID AND IsLocked = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAID", LDLAppID);
            command.Parameters.AddWithValue("@TTID", TestTypeID);

            bool IsFound = false;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                    IsFound = true;

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
        public static bool LockAppointment(int TestAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @" UPDATE TestAppointemnts SET IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            int RowsAffected = -1;
            bool Result = false;
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
                Result = RowsAffected > 0;
            }
            catch (Exception ex)
            {
                Result = false;
                clsErrorLog.AddErrorLog(ex);    
            }
            finally { connection.Close(); }
            return Result;
        }
        public static bool Delete(int ID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "DELETE TestAppointments WHERE TestAppointmentID = @ID";

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

        public static bool IsExists(int ID) 
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 1 FROM TestAppointments WHERE TestAppointmentID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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
    }
}
