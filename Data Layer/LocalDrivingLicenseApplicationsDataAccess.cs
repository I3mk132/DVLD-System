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


    }
}
