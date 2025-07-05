using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Layer
{
    public class clsDriversDataAccess
    {
        private static void _AddFilterConditions(
            SqlCommand command, int DriverID = -1, int PersonID = -1, 
            int CreatedByUserID = -1, DateTime? CreatedDate = null)
        {
            var conditions = new List<string>();

            if (DriverID != -1)
            {
                conditions.Add("DriverID = @DriverID");
                command.Parameters.AddWithValue("@DriverID", DriverID);
            }
            if (PersonID != -1)
            {
                conditions.Add("PersonID = @PersonID");
                command.Parameters.AddWithValue("@PersonID", PersonID);
            }
            if (CreatedByUserID != -1)
            {
                conditions.Add("CreatedByUserID = @CreatedByUserID");
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            }
            if (CreatedDate != null)
            {
                conditions.Add("CreatedDate = @CreatedDate");
                command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            }

            if (conditions.Any())
            {
                command.CommandText += " WHERE " + string.Join(" AND ", conditions);
            }
        }

        public enum enMode { Default, PersonJoined, PersonJoinedSimple }
        public static DataTable GetAllDrivers(enMode Type = enMode.Default)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "";
            switch (Type)
            {
                case enMode.Default:
                    query = @"SELECT * FROM Drivers";
                    break;
                case enMode.PersonJoined:
                    query = @"
                        SELECT  D.DriverID, P.PersonID, P.NationalNo,
                                P.Firstname, P.Secondname, P.Thirdname, P.Lastname,
                                P.DateOfBirth, P.Gender, P.Address,
                                P.Phone, P.Email, C.CountryName,
                                P.ImagePath, D.CreatedByUserID, D.CreatedDate FROM Drivers D
                        JOIN Person P ON D.PersonID = P.PersonID
                        JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
                case enMode.PersonJoinedSimple:
                    query = @"
                        SELECT  D.DriversID, P.NationalNo,
                                P.Firstname, P.Lastname,
                                P.DateOfBirth, P.Gender,
                                P.Phone, P.Email, C.CountryName,
                                D.CreatedDate FROM Drivers D
                        JOIN Person P ON D.PersonID = P.PersonID
                        JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
            }


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
        public static DataTable GetDrivers(
            int DriverID = -1, int PersonID = -1,
            int CreatedByUserID = -1, DateTime? CreatedDate = null,
            enMode Type = enMode.Default
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);


            string query = "";
            switch (Type)
            {
                case enMode.Default:
                    query = @"SELECT * FROM Drivers";
                    break;
                case enMode.PersonJoined:
                    query = @"
                        SELECT  D.DriverID, P.PersonID, P.NationalNo,
                                P.Firstname, P.Secondname, P.Thirdname, P.Lastname,
                                P.DateOfBirth, P.Gender, P.Address,
                                P.Phone, P.Email, C.CountryName,
                                P.ImagePath, D.CreatedByUserID, D.CreatedDate FROM Drivers D
                        JOIN Person P ON D.PersonID = P.PersonID
                        JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
                case enMode.PersonJoinedSimple:
                    query = @"
                        SELECT  D.DriversID, P.NationalNo,
                                P.Firstname, P.Lastname,
                                P.DateOfBirth, P.Gender,
                                P.Phone, P.Email, C.CountryName,
                                D.CreatedDate FROM Drivers D
                        JOIN Person P ON D.PersonID = P.PersonID
                        JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
            }

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, DriverID, PersonID, CreatedByUserID, CreatedDate);


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
        public static bool GetDriver(
            ref int DriverID, ref int PersonID,
            ref int CreatedByUserID, ref DateTime? CreatedDate
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Drivers";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, DriverID, PersonID, CreatedByUserID, CreatedDate);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    DriverID = (int)reader["DriverID"];
                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime?)reader["CreatedDate"];

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

        public static bool IsDriverExists(
            int DriverID = -1, int PersonID = -1,
            int CreatedByUserID = -1, DateTime? CreatedDate = null)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 1 FROM Drivers";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, DriverID, PersonID, CreatedByUserID, CreatedDate);

            bool isFound = false;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isFound = true;
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
        public static int AddDriver(
            int PersonID, int CreatedByUserID, DateTime? CreatedDate
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO Drivers 
                ( PersonID, CreatedByUserID, CreatedDate ) VALUES 
                ( @PersonID, @CreatedByUserID, @CreatedDate );
                SELECT SCOPE_IDENTITY();
            
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            int DriverID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                    DriverID = id;

            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return DriverID;
        }
        public static bool UpdateDriver(
            int DriverID, int PersonID, int CreatedByUserID, DateTime? CreatedDate
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE Drivers SET
                PersonID = @PersonID,
                CreatedByUserID = @CreatedByUserID,
                CreatedDate = @CreatedDate
                WHERE DriverID = @DriverID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@DriverID", DriverID);
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
                
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool DeleteDriver(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                DELETE Drivers WHERE DriverID = @DriverID;

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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
