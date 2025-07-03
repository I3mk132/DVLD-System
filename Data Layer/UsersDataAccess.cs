using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsUsersDataAccess
    {
        private static void _AddFilterConditions(
            SqlCommand command, int UserID = -1, int PersonID = -1,
            string Username = "", string Password = "", bool? IsActive = null)
        {
            var conditions = new List<string>();

            if (UserID != -1)
            {
                conditions.Add("UserID = @UserID");
                command.Parameters.AddWithValue("@UserID", UserID);
            }
            if (PersonID != -1)
            {
                conditions.Add("PersonID = @PersonID");
                command.Parameters.AddWithValue("@PersonID", PersonID);
            }
            if (Username != "")
            {
                conditions.Add("Username = @Username");
                command.Parameters.AddWithValue("@Username", Username);
            }
            if (Password != "")
            {
                conditions.Add("Password = @Password");
                command.Parameters.AddWithValue("@Password", Password);
            }
            if (IsActive != null)
            {
                conditions.Add("IsActive = @IsActive");
                command.Parameters.AddWithValue("@IsActive", IsActive);
            }

            if (conditions.Any())
            {
                command.CommandText += " WHERE " + string.Join(" AND ", conditions);
            }
        }
            
        public static DataTable GetAllUsers()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Users";

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
        public static bool GetUser(
            ref int UserID, ref int PersonID,
            ref string Username, ref string Password, ref bool? IsActive
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, UserID, PersonID, Username, Password, IsActive);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    IsActive = (bool?)reader["IsActive"];

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
        public static DataTable GetUsers(
            int UserID = -1, int PersonID = -1,
            string Username = "", string Password = "", bool? IsActive = null
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, UserID, PersonID, Username, Password, IsActive);


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

        public static bool isUserExists(
            int UserID = -1, int PersonID = -1,
            string Username = "", string Password = "", bool? IsActive = null)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 1 FROM Users";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, UserID, PersonID, Username, Password, IsActive);

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
        public static int AddUser(
            int PersonID, string Username, string Password, bool? IsActive
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO Users 
                ( PersonID, Username, Password, IsActive) VALUES 
                ( @PersonID, @Username, @Password, @IsActive);
                SELECT SCOPE_IDENTITY();
            
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            int UserID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                    UserID = id;

            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return UserID;
        }
        public static bool UpdateUser(
            int UserID, int PersonID, string Username, string Password, bool? IsActive
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE Users SET
                PersonID = @PersonID,
                Username = @Username,
                Password = @Password,
                IsActive = @IsActive
                WHERE UserID = @UserID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool DeleteUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                DELETE Users WHERE UserID = @UserID;

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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
