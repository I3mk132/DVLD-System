using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Data_Layer
{
    public class clsPersonDataAccess
    {
        private static void _AddFilterConditions(
            SqlCommand command, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, string Gender = "", string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = "")
        {
            var conditions = new List<string>();

            if (PersonID != -1)
            {
                conditions.Add("PersonID = @PersonID");
                command.Parameters.AddWithValue("@PersonID", PersonID);
            }
            if (!string.IsNullOrEmpty(NationalNo))
            {
                conditions.Add("NationalNo = @NationalNo");
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
            }
            if (!string.IsNullOrEmpty(Firstname))
            {
                conditions.Add("Firstname = @Firstname");
                command.Parameters.AddWithValue("@Firstname", Firstname);
            }
            if (!string.IsNullOrEmpty(Secondname))
            {
                conditions.Add("Secondname = @Secondname");
                command.Parameters.AddWithValue("@Secondname", Secondname);
            }
            if (!string.IsNullOrEmpty(Thirdname))
            {
                conditions.Add("Thirdname = @Thirdname");
                command.Parameters.AddWithValue("@Thirdname", Thirdname);
            }
            if (!string.IsNullOrEmpty(Lastname))
            {
                conditions.Add("Lastname = @Lastname");
                command.Parameters.AddWithValue("@Lastname", Lastname);
            }
            if (DateOfBirth != null)
            {
                conditions.Add("DateOfBirth = @DateOfBirth");
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            }
            if (Gender != "")
            {
                conditions.Add("Gender = @Gender");
                command.Parameters.AddWithValue("@Gender", Gender);
            }
            if (!string.IsNullOrEmpty(Address))
            {
                conditions.Add("Address = @Address");
                command.Parameters.AddWithValue("@Address", Address);
            }
            if (!string.IsNullOrEmpty(Phone))
            {
                conditions.Add("Phone = @Phone"); 
                command.Parameters.AddWithValue("@Phone", Phone);
            }
            if (!string.IsNullOrEmpty(Email))
            {
                conditions.Add("Email = @Email");
                command.Parameters.AddWithValue("@Email", Email);
            }
            if (!string.IsNullOrEmpty(Country))
            {
                conditions.Add("Country = @Country");
                command.Parameters.AddWithValue("@Country", Country);
            }
            if (!string.IsNullOrEmpty(ImagePath))
            {
                conditions.Add("ImagePath = @ImagePath");
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }

            if (conditions.Any())
            {
                command.CommandText += " WHERE " + string.Join(" AND ", conditions);
            }
        }
        private static void _AddFilterConditionsUsingLike(
            SqlCommand command, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, string Gender = "", string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = "")
        {
            var conditions = new List<string>();

            if (PersonID != -1)
            {
                conditions.Add("PersonID = @PersonID");
                command.Parameters.AddWithValue("@PersonID", PersonID);
            }
            if (!string.IsNullOrEmpty(NationalNo))
            {
                conditions.Add("NationalNo LIKE @NationalNo");
                command.Parameters.AddWithValue("@NationalNo", $"%{NationalNo}%");
            }
            if (!string.IsNullOrEmpty(Firstname))
            {
                conditions.Add("Firstname LIKE @Firstname");
                command.Parameters.AddWithValue("@Firstname", $"%{Firstname}%");
            }
            if (!string.IsNullOrEmpty(Secondname))
            {
                conditions.Add("Secondname LIKE @Secondname");
                command.Parameters.AddWithValue("@Secondname", $"%{Secondname}%");
            }
            if (!string.IsNullOrEmpty(Thirdname))
            {
                conditions.Add("Thirdname LIKE @Thirdname");
                command.Parameters.AddWithValue("@Thirdname", $"%{Thirdname}%");
            }
            if (!string.IsNullOrEmpty(Lastname))
            {
                conditions.Add("Lastname LIKE @Lastname");
                command.Parameters.AddWithValue("@Lastname", $"%{Lastname}%");
            }
            if (DateOfBirth != null)
            {
                conditions.Add("DateOfBirth = @DateOfBirth");
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            }
            if (Gender != "")
            {
                conditions.Add("Gender Like @Gender");
                command.Parameters.AddWithValue("@Gender", $"{Gender}%");
            }
            if (!string.IsNullOrEmpty(Address))
            {
                conditions.Add("Address LIKE @Address");
                command.Parameters.AddWithValue("@Address", $"%{Address}%");
            }
            if (!string.IsNullOrEmpty(Phone))
            {
                conditions.Add("Phone LIKE @Phone");
                command.Parameters.AddWithValue("@Phone", $"%{Phone}%");
            }
            if (!string.IsNullOrEmpty(Email))
            {
                conditions.Add("Email LIKE @Email");
                command.Parameters.AddWithValue("@Email", $"%{Email}%");
            }
            if (!string.IsNullOrEmpty(Country))
            {
                conditions.Add("Country LIKE @Country");
                command.Parameters.AddWithValue("@Country", $"%{Country}%");
            }
            if (!string.IsNullOrEmpty(ImagePath))
            {
                conditions.Add("ImagePath LIKE @ImagePath");
                command.Parameters.AddWithValue("@ImagePath", $"%{ImagePath}%");
            }

            if (conditions.Any())
            {
                command.CommandText += " WHERE " + string.Join(" AND ", conditions);
            }

        }

        public enum enMode { Default, Simple }
        public static DataTable GetAllPerson(enMode Type = enMode.Default)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "";

            switch (Type)
            {
                case enMode.Default:
                    query = @"SELECT * 
                            FROM Person P JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;

                case enMode.Simple:
                    query = @"
                        SELECT 
                            P.PersonID AS 'Person ID', 
                            P.NationalNo AS 'National No.', 
                            P.Firstname AS 'First Name', 
                            P.Secondname AS 'Second Name', 
                            P.Thirdname AS 'Third Name', 
                            P.Lastname AS 'Last Name', 
                            P.Gender,
                            P.DateOfBirth AS 'Date Of Birth',
                            C.CountryName AS 'Nationality',
                            P.Phone,
                            P.Email
                        FROM Person P JOIN Countries C ON P.NationalityCountryID = C.CountryID";
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
        public static bool GetPerson(
            ref int PersonID, ref string NationalNo, ref string Firstname, ref string Secondname, ref string Thirdname,
            ref string Lastname, ref DateTime? DateOfBirth, ref string Gender, ref string Address, ref string Phone, 
            ref string Email, ref string Country, ref string ImagePath
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Person P JOIN Countries C ON P.NationalityCountryID = C.CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, PersonID, NationalNo, Firstname, Secondname, Thirdname, Lastname, 
                DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    NationalNo = (string)reader["NationalNo"];
                    Firstname = (string)reader["Firstname"];
                    Secondname = (string)reader["Secondname"];
                    Thirdname = (string)reader["Thirdname"];
                    Lastname = (string)reader["Lastname"];
                    DateOfBirth = (DateTime?)reader["DateOfBirth"];
                    Gender = (string)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Country = (string)reader["CountryName"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";
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
        public static bool GetPersonUsingLike(
            ref int PersonID, ref string NationalNo, ref string Firstname, ref string Secondname, ref string Thirdname,
            ref string Lastname, ref DateTime? DateOfBirth, ref string Gender, ref string Address, ref string Phone,
            ref string Email, ref string Country, ref string ImagePath
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Person P JOIN Countries C ON P.NationalityCountryID = C.CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditionsUsingLike(command, PersonID, NationalNo, Firstname, Secondname, Thirdname, Lastname,
                DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath);

            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    NationalNo = (string)reader["NationalNo"];
                    Firstname = (string)reader["Firstname"];
                    Secondname = (string)reader["Secondname"];
                    Thirdname = (string)reader["Thirdname"];
                    Lastname = (string)reader["Lastname"];
                    DateOfBirth = (DateTime?)reader["DateOfBirth"];
                    Gender = (string)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Country = (string)reader["CountryName"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

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

        public static DataTable GetPeople(
            int PersonID = -1, string NationalNo = "", string Firstname = "", string Secondname = "", string Thirdname = "",
            string Lastname = "", DateTime? DateOfBirth = null, string Gender = "", string Address = "", string Phone = "",
            string Email = "", string Country = "", string ImagePath = "", enMode Type = enMode.Default
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "";

            switch (Type)
            {
                case enMode.Default:
                    query = @"SELECT * 
                            FROM Person P JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;

                case enMode.Simple:
                    query = @"
                        SELECT 
                            P.PersonID AS 'Person ID', 
                            P.NationalNo AS 'National No.', 
                            P.Firstname AS 'First Name', 
                            P.Secondname AS 'Second Name', 
                            P.Thirdname AS 'Third Name', 
                            P.Lastname AS 'Last Name', 
                            P.Gender,
                            P.DateOfBirth AS 'Date Of Birth',
                            C.CountryName AS 'Nationality',
                            P.Phone,
                            P.Email
                        FROM Person P JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
            }



            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, PersonID, NationalNo, Firstname, Secondname, Thirdname, Lastname,
                DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath);


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
        public static DataTable GetPeopleUsingLike(
            int PersonID = -1, string NationalNo = "", string Firstname = "", string Secondname = "", string Thirdname = "",
            string Lastname = "", DateTime? DateOfBirth = null, string Gender = "", string Address = "", string Phone = "",
            string Email = "", string Country = "", string ImagePath = "", enMode Type = enMode.Default
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "";

            switch (Type)
            {
                case enMode.Default:
                    query = @"SELECT * 
                            FROM Person P JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;

                case enMode.Simple:
                    query = @"
                        SELECT 
                            P.PersonID AS 'Person ID', 
                            P.NationalNo AS 'National No.', 
                            P.Firstname AS 'First Name', 
                            P.Secondname AS 'Second Name', 
                            P.Thirdname AS 'Third Name', 
                            P.Lastname AS 'Last Name', 
                            P.Gender,
                            P.DateOfBirth AS 'Date Of Birth',
                            C.CountryName AS 'Nationality',
                            P.Phone,
                            P.Email
                        FROM Person P JOIN Countries C ON P.NationalityCountryID = C.CountryID";
                    break;
            }



            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditionsUsingLike(command, PersonID, NationalNo, Firstname, Secondname, Thirdname, Lastname,
                DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath);


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

        public static bool IsPersonExists(
            int PersonID = -1, string NationalNo = "", string Firstname = "", string Secondname = "", string Thirdname = "",
            string Lastname = "", DateTime? DateOfBirth = null, string Gender = "", string Address = "", string Phone = "",
            string Email = "", string Country = "", string ImagePath = "")
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT 1 FROM Person";

            SqlCommand command = new SqlCommand(query, connection);

            _AddFilterConditions(command, PersonID, NationalNo, Firstname, Secondname, Thirdname, Lastname,
                DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath);

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
        public static int AddPerson(
            string NationalNo, string Firstname, string Secondname, string Thirdname,
            string Lastname, DateTime? DateOfBirth, string Gender, string Address, string Phone,
            string Email, string Country, string ImagePath = ""
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO Person 
                ( NationalNo, Firstname, Secondname, Thirdname, Lastname, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath) VALUES 
                ( @NationalNo, @Firstname, @Secondname, @Thirdname, @Lastname, @DateOfBirth, @Gender, @Address, @Phone, @Email, (SELECT TOP 1 CountryID FROM Countries WHERE CountryName = @Country), @ImagePath);
                SELECT SCOPE_IDENTITY();
            
            ";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            command.Parameters.AddWithValue("@Secondname", Secondname);
            command.Parameters.AddWithValue("@Thirdname", Thirdname);
            command.Parameters.AddWithValue("@Lastname", Lastname);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Country", Country);
            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                int PersonID = -1;
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int id))
                    PersonID = id;

            }
            catch (Exception ex)
            {
                clsErrorLog.AddErrorLog(ex);
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }
        public static bool UpdatePerson(
            int PersonID, string NationalNo, string Firstname, string Secondname, string Thirdname,
            string Lastname, DateTime? DateOfBirth, string Gender, string Address, string Phone,
            string Email, string Country, string ImagePath = ""
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                UPDATE Person SET
                NationalNo = @NationalNo,
                Firstname = @Firstname,
                Secondname = @Secondname,
                Thirdname = @Thirdname,
                Lastname = @Lastname,
                DateOfBirth = @DateOfBirth,
                Gender = @Gender,
                Address = @Address,
                Phone = @Phone,
                Email = @Email,
                NationalityCountryID = (SELECT TOP 1 CountryID FROM Countries WHERE CountryName = @Country),
                ImagePath = @ImagePath
                WHERE PersonID = @PersonID

            ";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            command.Parameters.AddWithValue("@Secondname", Secondname);
            command.Parameters.AddWithValue("@Thirdname", Thirdname);
            command.Parameters.AddWithValue("@Lastname", Lastname);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Country", Country);
            if (ImagePath != "") 
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                DELETE Person WHERE PersonID = @PersonID;

            ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
