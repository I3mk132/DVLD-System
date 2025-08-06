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
    public class clsTestsDataAccess
    {
        public static DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Tests";

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

        public static int Add(
            int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO Tests 
                (TestAppointmentID, TestResult, Notes, CreatedByUserID) Values 
                (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
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
            int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID
            )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE Tests SET
                TestAppointmentID = @TestAppointmentID,
                TestResult = @TestResult,
                Notes = @Notes,
                CreatedByUserID = @CreatedByUserID,
                WHERE TestID = @ID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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
            ref int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Tests WHERE TestID = @ID";

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

                    TestID = (int)reader["TestID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                        Notes = "";

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

            string query = "DELETE Tests WHERE TestID = @ID";

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

        public static int PassedTestCount(int LDLAppID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                Select count(*)
	                From Tests T
		                JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID
	                WHERE 
		                TA.LocalDrivingLicenseApplicationID = @LDLAppID AND T.TestResult = 1
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            int Count = -1;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    Count = (int)result;
            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close ();
            }
            return Count;
        }
        public static int TrialCount(int LDLAppID, int TestType)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                Select count(*)
	                From Tests T
		                JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID
	                WHERE 
		                TA.LocalDrivingLicenseApplicationID = @LDLAppID AND T.TestResult = 0 AND TA.TestTypeID = @TestType
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestType", TestType);

            int Count = -1;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    Count = (int)result;
            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return Count;

        }
        public static bool TestPassed(int LDLAppID, int TestType)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                Select 1
	                From Tests T
		                JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID
	                WHERE 
		                TA.LocalDrivingLicenseApplicationID = @LDLAppID AND T.TestResult = 1 AND TA.TestTypeID = @TestType
            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestType", TestType);

            bool Passed = false;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    Passed = true;
            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
                Passed = false;
            }
            finally
            {
                connection.Close();
            }
            return Passed;

        }
    }
}
