using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class clsPersonDateAccess
    {
        private static void _AddFilterConditions(
            SqlCommand command, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, short Gender = -1, string Address = "",
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
            if (Gender != -1)
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

        public static DataTable GetAllPerson()
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Person";

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
            ref string Lastname, ref DateTime? DateOfBirth, ref short Gender, ref string Address, ref string Phone, 
            ref string Email, ref string Country, ref string ImagePath
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Person";

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
                    Gender = (short)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Country = (string)reader["Country"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];

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
        public static DataTable GetPersons(
            int PersonID = -1, string NationalNo = "", string Firstname = "", string Secondname = "", string Thirdname = "",
            string Lastname = "", DateTime? DateOfBirth = null, short Gender = -1, string Address = "", string Phone = "",
            string Email = "", string Country = "", string ImagePath = ""
        )
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"SELECT * FROM Person";

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

        public static bool IsPersonExists(
            int PersonID = -1, string NationalNo = "", string Firstname = "", string Secondname = "", string Thirdname = "",
            string Lastname = "", DateTime? DateOfBirth = null, short Gender = -1, string Address = "", string Phone = "",
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
            string Lastname, DateTime? DateOfBirth, short Gender, string Address, string Phone,
            string Email, string Country, string ImagePath = ""
        )
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"

                INSERT INTO Person 
                ( NationalNo, Firstname, Secondname, Thirdname, Lastname, DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath) VALUES 
                ( @NationalNo, @Firstname, @Secondname, @Thirdname, @Lastname, @DateOfBirth, @Gender, @Address, @Phone, @Email, @Country, @ImagePath);
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
            string Lastname, DateTime? DateOfBirth, short Gender, string Address, string Phone,
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
                Country = @Country,
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
