using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsLocalDrivingLicenseApplicationsDataAccess
    {
        public static int Add(int ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO LocalDrivingLicenseApplications 
                (ApplicationID, LicenseClassID) Values (@ApplicationID, @LicenseClassID);
                SELECT SCOPE_IDENTITY();

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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
        public static DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                SELECT 
	                LD.LocalDrivingLicenseApplicationID AS [L.D.L.APPID],
	                LC.ClassName AS [Driving Class],
	                P.NationalNo AS [National No.],
	                P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname AS [Fullname],
	                A.ApplicationDate AS [Application Date],
	                (
	                Select count(*)
	                From Tests T
		                JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID
		                JOIN LocalDrivingLicenseApplications LD2 ON TA.LocalDrivingLicenseApplicationID = LD2.ApplicationID
		                JOIN Applications A2 ON A2.ApplicationID = LD2.ApplicationID
	                WHERE 
		                A2.PersonID = P.PersonID AND T.TestResult = 1
	                ) AS [Passed Tests],
	                CASE A.ApplicationStatus
		                WHEN 1 THEN 'New' 
		                WHEN 2 THEN 'Cancelled'
                        WHEN 3 THEN 'Compleated'
		                ELSE 'Other'
	                END AS Status

                FROM LocalDrivingLicenseApplications LD
	                JOIN Applications A ON A.ApplicationID = LD.ApplicationID
	                JOIN LicenseClasses LC ON LD.LicenseClassID = LC.LicenseClassID
	                JOIN Person P ON A.PersonID = P.PersonID;";

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
        public static DataTable GetAllFiltered(
            int LocalDrivingLicenseApplicationID = -1, string NationalNo = "", string Fullname = "", string Status = "")
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                SELECT 
	                LD.LocalDrivingLicenseApplicationID AS [L.D.L.APPID],
	                LC.ClassName AS [Driving Class],
	                P.NationalNo AS [National No.],
	                P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname AS [Fullname],
	                A.ApplicationDate AS [Application Date],
	                (
	                Select count(*)
	                From Tests T
		                JOIN TestAppointments TA ON T.TestAppointmentID = TA.TestAppointmentID
		                JOIN LocalDrivingLicenseApplications LD2 ON TA.LocalDrivingLicenseApplicationID = LD2.LocalDrivingLicenseApplicationID
		                JOIN Applications A2 ON A2.ApplicationID = LD2.ApplicationID
	                WHERE 
		                A2.PersonID = P.PersonID AND T.TestResult = 1
	                ) AS [Passed Tests],
	                CASE A.ApplicationStatus
		                WHEN 1 THEN 'New' 
		                WHEN 2 THEN 'Cancelled'
                        WHEN 3 THEN 'Compleated'
		                ELSE 'Other'
	                END AS Status
                FROM LocalDrivingLicenseApplications LD
	                JOIN Applications A ON LD.ApplicationID = A.ApplicationID
	                JOIN LicenseClasses LC ON LD.LicenseClassID = LC.LicenseClassID
	                JOIN Person P ON P.PersonID = A.PersonID

                WHERE 
                    (@LocalDrivingLicenseApplicationID IS NULL OR 
                    LD.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) AND

                    (@NationalNo IS NULL OR 
                     P.NationalNo LIKE '%' + @NationalNo + '%') AND

                    (@Fullname IS NULL OR 
                     P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname LIKE '%' + @Fullname + '%') AND

                    (@Status IS NULL OR 
                     A.ApplicationStatus = @Status)

                
            ";

            SqlCommand command = new SqlCommand(query, connection);

            if (LocalDrivingLicenseApplicationID != -1)
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            else
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", DBNull.Value);

            if (!string.IsNullOrEmpty(NationalNo))
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
            else
                command.Parameters.AddWithValue("@NationalNo", DBNull.Value);

            if (!string.IsNullOrEmpty(Fullname))
                command.Parameters.AddWithValue("@Fullname", Fullname);
            else
                command.Parameters.AddWithValue("@Fullname", DBNull.Value);
            
            if (!string.IsNullOrEmpty(Status))

                switch (Status)
                {
                    case "New": command.Parameters.AddWithValue("@Status", 1); break;
                    case "Cancelled": command.Parameters.AddWithValue("@Status", 2); break;
                    case "Compleated": command.Parameters.AddWithValue("@Status", 3); break;
                    default: command.Parameters.AddWithValue("@Status", DBNull.Value); break;
                }
                
            else
                command.Parameters.AddWithValue("@Status", DBNull.Value);


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

        public static bool Update(int LocalDrivingLicenseApplicationID,int ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE LocalDrivingLicenseApplications SET
                ApplicationID = @ApplicationID,
                LicenseClassID = @LicenseClassID
                WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
        public static bool Find(ref int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 
                                ApplicationID, LicenseClassID, 
                            FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", LocalDrivingLicenseApplicationID);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

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

    }
}
