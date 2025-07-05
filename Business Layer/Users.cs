using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsUsers : clsPerson
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }

        private enMode _Mode;

        public clsUsers() : base()
        {
            UserID = -1;
            Username = "";
            Password = "";
            IsActive = null;

            _Mode = enMode.AddNew;
        }

        private clsUsers(

            int UserID,
            int PersonID,
            string NationalNo,
            string Firstname,
            string Secondname,
            string Thirdname,
            string Lastname,
            DateTime? DateOfBirth,
            string Gender,
            string Address,
            string Phone,
            string Email,
            string Country,
            string ImagePath,
            string Username,
            string Password,
            bool? IsActive

            ) : base(
                
                PersonID, NationalNo, Firstname, Secondname,
                Thirdname, Lastname, DateOfBirth, Gender, 
                Address, Phone, Email, Country, ImagePath
                
                )
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            _Mode = enMode.Update;
        }
        private static string HashPassword(string Password)
        {
            // Generate Salt
            byte[] salt = new byte[16];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(salt);

            // PBKDF2 hash with (sha1)
            var pdkdf2 = new Rfc2898DeriveBytes(Password, salt, 100_000);
            byte[] hash = pdkdf2.GetBytes(32);

            byte[] hashBytes = new byte[48];
            Buffer.BlockCopy(salt, 0, hashBytes, 0, 16);
            Buffer.BlockCopy(hash, 0, hashBytes, 16, 32);

            return Convert.ToBase64String(hashBytes);
        }
        private static bool VerifyPassword(string Password, string HashedPassword)
        {
            byte[] hashbytes = Convert.FromBase64String(HashedPassword);

            // Extract salt
            byte[] salt = new byte[16];
            Buffer.BlockCopy(hashbytes, 0, salt, 0, 16);

            // Hash Entered Password
            var pdkdf2 = new Rfc2898DeriveBytes(Password, salt, 100_000);
            byte[] hash = pdkdf2.GetBytes(32);

            // Compare two
            for (int i = 0; i < 32; i++)
            {
                if (hash[i] != hashbytes[i + 16])
                    return false;
            }
            return true;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }
        public static clsUsers Find(
            int UserID = -1, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, string Gender = "", string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = "",
            string Username = "", bool? IsActive = null
        )
        {
            
            if (UserID != -1 || !string.IsNullOrEmpty(Username) || IsActive != null)
            {
                int tempUserID = UserID, tempPersonID = PersonID;
                string tempUsername = Username, tempPassword = "";
                bool? tempIsActive = IsActive;

                if (clsUsersDataAccess.GetUser(ref tempUserID, ref tempPersonID, ref tempUsername, ref tempPassword, ref tempIsActive))
                {
                    PersonID = tempPersonID;
                }
            }

            
            string password = "";
            if (clsPersonDataAccess.GetPerson(ref PersonID, ref NationalNo, ref Firstname, ref Secondname,
                ref Thirdname, ref Lastname, ref DateOfBirth, ref Gender, ref Address, ref Phone,
                ref Email, ref Country, ref ImagePath))
            {
                
                if (clsUsersDataAccess.GetUser(ref UserID, ref PersonID, ref Username, ref password, ref IsActive))
                {
                    return new clsUsers(UserID, PersonID, NationalNo, Firstname, Secondname, Thirdname,
                        Lastname, DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath,
                        Username, password, IsActive);
                }
            }

            return null;
        }
        public static clsUsers FindUsingLike(
            int UserID = -1, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, string Gender = "", string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = "",
            string Username = "", bool? IsActive = null
        )
        {

            if (UserID != -1 || !string.IsNullOrEmpty(Username) || IsActive != null)
            {
                int tempUserID = UserID, tempPersonID = PersonID;
                string tempUsername = Username, tempPassword = "";
                bool? tempIsActive = IsActive;

                if (clsUsersDataAccess.GetUserUsingLike(ref tempUserID, ref tempPersonID, ref tempUsername, ref tempPassword, ref tempIsActive))
                {
                    PersonID = tempPersonID;
                }
            }


            string password = "";
            if (clsPersonDataAccess.GetPersonUsingLike(ref PersonID, ref NationalNo, ref Firstname, ref Secondname,
                ref Thirdname, ref Lastname, ref DateOfBirth, ref Gender, ref Address, ref Phone,
                ref Email, ref Country, ref ImagePath))
            {

                if (clsUsersDataAccess.GetUserUsingLike(ref UserID, ref PersonID, ref Username, ref password, ref IsActive))
                {
                    return new clsUsers(UserID, PersonID, NationalNo, Firstname, Secondname, Thirdname,
                        Lastname, DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath,
                        Username, password, IsActive);
                }
            }

            return null;
        }
        public static DataTable GetUsersWith(
            int UserID = -1, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, string Gender = "", string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = "",
            string Username = "", bool? IsActive = null
        )
        {
            clsPerson person = clsPerson.Find(
                PersonID, NationalNo, Firstname, Secondname,
                Thirdname, Lastname, DateOfBirth, Gender,
                Address, Phone, Email, Country, ImagePath);

            return clsUsersDataAccess.GetUsers(UserID, (person != null ? person.PersonID : -1), Username, "", IsActive);
        }
        public static DataTable GetUsersUsingLikeWith(
            int UserID = -1, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, string Gender = "", string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = "",
            string Username = "", bool? IsActive = null
        )
        {
            clsPerson person = clsPerson.FindUsingLike(
                PersonID, NationalNo, Firstname, Secondname,
                Thirdname, Lastname, DateOfBirth, Gender,
                Address, Phone, Email, Country, ImagePath);

            return clsUsersDataAccess.GetUsersUsingLike(UserID, (person != null ? person.PersonID : -1), Username, "", IsActive);
        }
        public static bool IsUserExists(int ID)
        {
            return clsUsersDataAccess.IsUserExists(ID);
        }
        public static bool DeleteUser(int ID)
        {
            clsUsers user = clsUsers.Find(UserID: ID);
            if (clsPerson.DeletePerson(user.PersonID))
            {
                return clsUsersDataAccess.DeleteUser(UserID: user.UserID);
            }
            return false;
        }
        public static DataTable GetAllUsersAllData()
        {
            return clsUsersDataAccess.GetAllUsers(clsUsersDataAccess.enMode.PersonJoined);
        }
        public static string GetUserFullName(int ID)
        {
            return GetPersonFullName(ID);
        }
        public static bool? IsUserActive(int ID)
        {
            clsUsers user = Find(UserID: ID);
            return user?.IsActive;
        }
        public static clsUsers GetActiveUser()
        {
            return clsUsers.Find(IsActive: true);
        }

        public static clsUsers Authenticate(string username, string password)
        {
            clsUsers user = Find(Username: username);
            if (user != null && VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }


        private bool _AddNewUser()
        {
            clsPerson person = new clsPerson();

            person.NationalNo = NationalNo;
            person.Firstname = Firstname;
            person.Secondname = Secondname;
            person.Thirdname = Thirdname;
            person.Lastname = Lastname;
            person.DateOfBirth = DateOfBirth;
            person.Gender = Gender;
            person.Address = Address;
            person.Phone = Phone;
            person.Email = Email;
            person.Country = Country;
            person.ImagePath = ImagePath;


            if( person.Save() )
            {
                this.UserID = clsUsersDataAccess.AddUser(PersonID, Username, HashPassword(Password), IsActive);
                return (this.UserID != -1);
            }
            return false;
        }
        private bool _UpdateUser()
        {
            clsPerson person = clsPerson.Find(PersonID: PersonID);
            
            person.NationalNo = NationalNo;
            person.Firstname = Firstname;
            person.Secondname = Secondname;
            person.Thirdname = Thirdname;
            person.Lastname = Lastname;
            person.DateOfBirth = DateOfBirth;
            person.Gender = Gender;
            person.Address = Address;
            person.Phone = Phone;
            person.Email = Email;
            person.Country = Country;
            person.ImagePath = ImagePath;

            if (person.Save())
            {
                return clsUsersDataAccess.UpdateUser(UserID, PersonID, Username, HashPassword(Password), IsActive);
            }

            return false;
        }
        public new bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewUser())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return (_UpdateUser());
            }
        }

    }
}
