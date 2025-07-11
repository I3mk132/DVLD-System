﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
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
                conditions.Add("U.UserID = @UserID");
                command.Parameters.AddWithValue("@UserID", UserID);
            }
            if (PersonID != -1)
            {
                conditions.Add("U.PersonID = @PersonID");
                command.Parameters.AddWithValue("@PersonID", PersonID);
            }
            if (Username != "")
            {
                conditions.Add("U.Username = @Username");
                command.Parameters.AddWithValue("@Username", Username);
            }
            if (Password != "")
            {
                conditions.Add("U.Password = @Password");
                command.Parameters.AddWithValue("@Password", Password);
            }
            if (IsActive != null)
            {
                conditions.Add("U.IsActive = @IsActive");
                command.Parameters.AddWithValue("@IsActive", IsActive);
            }

            if (conditions.Any())
            {
                command.CommandText += " WHERE " + string.Join(" AND ", conditions);
            }
        }
        private static void _AddFilterConditionsUsingLike(
            SqlCommand command, int UserID = -1, int PersonID = -1,
            string Username = "", string Password = "", bool? IsActive = null)
        {
            var conditions = new List<string>();

            if (UserID != -1)
            {
                conditions.Add("U.UserID = @UserID");
                command.Parameters.AddWithValue("@UserID", UserID);
            }
            if (PersonID != -1)
            {
                conditions.Add("U.PersonID = @PersonID");
                command.Parameters.AddWithValue("@PersonID", PersonID);
            }
            if (Username != "")
            {
                conditions.Add("U.Username LIKE @Username");
                command.Parameters.AddWithValue("@Username", $"%{Username}%");
            }
            if (Password != "")
            {
                conditions.Add("U.Password = @Password");
                command.Parameters.AddWithValue("@Password", Password);
            }
            if (IsActive != null)
            {
                conditions.Add("U.IsActive = @IsActive");
                command.Parameters.AddWithValue("@IsActive", IsActive);
            }

            if (conditions.Any())
            {
                command.CommandText += " WHERE " + string.Join(" OR ", conditions);
            }
            else
            {
                command.CommandText += " WHERE 1 = 0";
            }
        }

        public enum enMode { Default, PersonJoined, PersonJoinedSimple }
        public static DataTable GetAllUsers(enMode Type = enMode.Default)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "";
            switch (Type)
            {
                case enMode.Default:
                    query = @"SELECT * FROM Users U";
                    break;
                case enMode.PersonJoined:
                    query = @"
                        SELECT  U.UserID, P.PersonID, P.NationalNo,
                                P.Firstname, P.Secondname, P.Thirdname, P.Lastname,
                                P.DateOfBirth, P.Gender, P.Address,
                                P.Phone, P.Email, C.CountryName,
                                P.ImagePath, U.Username, U.Password, U.IsActive FROM Users U
                        JOIN Person P ON U.PersonID = P.PersonID
                        JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
                case enMode.PersonJoinedSimple:
                    query = @"
                        SELECT  U.UserID, P.PersonID,
                                P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname AS Fullname,
                                U.Username, U.IsActive FROM Users U
                        JOIN Person P ON U.PersonID = P.PersonID";
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
        public static DataTable GetUsers(
            int UserID = -1, int PersonID = -1,
            string Username = "", string Password = "", bool? IsActive = null,
            enMode Type = enMode.Default
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "";
            switch (Type)
            {
                case enMode.Default:
                    query = @"SELECT * FROM Users U";
                    break;
                case enMode.PersonJoined:
                    query = @"
                        SELECT  U.UserID, P.PersonID, P.NationalNo,
                                P.Firstname, P.Secondname, P.Thirdname, P.Lastname,
                                P.DateOfBirth, P.Gender, P.Address,
                                P.Phone, P.Email, C.CountryName,
                                P.ImagePath, U.Username, U.Password, U.IsActive FROM Users U
                        JOIN Person P ON U.PersonID = P.PersonID
                        JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
                case enMode.PersonJoinedSimple:
                    query = @"
                        SELECT  U.UserID, P.PersonID,
                                P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname AS Fullname,
                                U.Username, U.IsActive FROM Users U
                        JOIN Person P ON U.PersonID = P.PersonID";
                    break;
            }

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
        public static DataTable GetUsersUsingLike(
            int UserID = -1, int PersonID = -1,
            string Username = "", string Password = "", bool? IsActive = null,
            enMode Type = enMode.Default
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "";
            switch (Type)
            {
                case enMode.Default:
                    query = @"SELECT * FROM Users U";
                    break;
                case enMode.PersonJoined:
                    query = @"
                        SELECT  U.UserID, P.PersonID, P.NationalNo,
                                P.Firstname, P.Secondname, P.Thirdname, P.Lastname,
                                P.DateOfBirth, P.Gender, P.Address,
                                P.Phone, P.Email, C.CountryName,
                                P.ImagePath, U.Username, U.Password, U.IsActive FROM Users U
                        JOIN Person P ON U.PersonID = P.PersonID
                        JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
                case enMode.PersonJoinedSimple:
                    query = @"
                        SELECT  U.UserID, U.PersonID,
                                P.Firstname + ' ' + P.Secondname + ' ' + P.Thirdname + ' ' + P.Lastname AS Fullname,
                                U.Username, U.IsActive FROM Users U
                        JOIN Person P ON U.PersonID = P.PersonID";
                    break;
            }

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditionsUsingLike(command, UserID, PersonID, Username, Password, IsActive);


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

            string query = @"SELECT * FROM Users U";

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
        public static bool GetUserUsingLike(
            ref int UserID, ref int PersonID,
            ref string Username, ref string Password, ref bool? IsActive
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Users U";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditionsUsingLike(command, UserID, PersonID, Username, Password, IsActive);

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

        public static bool IsUserExists(
            int UserID = -1, int PersonID = -1,
            string Username = "", string Password = "", bool? IsActive = null)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 1 FROM Users U";

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
        public static bool ActivateUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"
                UPDATE Users SET
                    IsActive = 1
                WHERE UserID = @UserID";
                    

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("UserID", UserID);

            bool result = false;
            int rowsAffected = 0;
            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
                result = (rowsAffected > 0);
            }
            catch (Exception ex)
            {
                result = false;
                clsErrorLog.AddErrorLog (ex);
            }
            finally 
            { 
                connection.Close(); 
            }
            return result;
        }
        public static bool DeactivateUser(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"
                Update Users SET
	                IsActive = 0
                WHERE UserID = @UserID AND IsActive = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("UserID", UserID);

            bool result = false;
            int rowsAffected = 0;
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
        
    }
}
