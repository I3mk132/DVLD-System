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
    public class clsDrivers : clsPerson
    {
        public int DriverID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? CreatedDate { get; set; }

        private enMode _Mode;

        public clsDrivers() : base()
        {
            DriverID = -1;
            CreatedByUserID = -1;
            CreatedDate = null;

            _Mode = enMode.AddNew;
        }

        private clsDrivers(

            int DriverID,
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
            int CreatedByUserID,
            DateTime? CreatedDate

            ) : base(

                PersonID, NationalNo, Firstname, Secondname,
                Thirdname, Lastname, DateOfBirth, Gender,
                Address, Phone, Email, Country, ImagePath

                )
        {
            this.DriverID = DriverID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;

            _Mode = enMode.Update;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriversDataAccess.GetAllDrivers();
        }
        public static clsDrivers Find(
            int DriverID = -1, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, string Gender = "", string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = "",
            int CreatedByUserID = -1, DateTime? CreatedDate = null
        )
        {

            if (DriverID != -1 || CreatedByUserID != -1 || CreatedDate != null)
            {
                int tempDriverID = DriverID, tempPersonID = PersonID;
                int tempCreatedByUserID = CreatedByUserID;
                DateTime? tempCreatedDate = CreatedDate;

                if (clsDriversDataAccess.GetDriver(ref tempDriverID, ref tempPersonID, ref tempCreatedByUserID, ref tempCreatedDate))
                {
                    PersonID = tempPersonID;
                }
            }

            if (clsPersonDataAccess.GetPerson(ref PersonID, ref NationalNo, ref Firstname, ref Secondname,
                ref Thirdname, ref Lastname, ref DateOfBirth, ref Gender, ref Address, ref Phone,
                ref Email, ref Country, ref ImagePath))
            {

                if (clsDriversDataAccess.GetDriver(ref DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                {
                    return new clsDrivers(DriverID, PersonID, NationalNo, Firstname, Secondname, Thirdname,
                        Lastname, DateOfBirth, Gender, Address, Phone, Email, Country, ImagePath,
                        CreatedByUserID, CreatedDate);
                }
            }

            return null;
        }
        public static DataTable GetDriversWith(
            int DriverID = -1, int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, string Gender = "", string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = "",
            int CreatedByUserID = -1, DateTime? CreatedDate = null
        )
        {
            clsPerson person = clsPerson.Find(
                PersonID, NationalNo, Firstname, Secondname,
                Thirdname, Lastname, DateOfBirth, Gender,
                Address, Phone, Email, Country, ImagePath);

            return clsDriversDataAccess.GetDrivers(DriverID, (person != null ? person.PersonID : -1), CreatedByUserID, CreatedDate);
        }
        public static bool IsDriverExists(int ID)
        {
            return clsDriversDataAccess.IsDriverExists(ID);
        }
        public static bool DeleteDriver(int ID)
        {
            clsDrivers driver = clsDrivers.Find(DriverID: ID);
            if (clsPerson.DeletePerson(driver.PersonID))
            {
                return clsDriversDataAccess.DeleteDriver(DriverID: driver.DriverID);
            }
            return false;
        }
        public static DataTable GetAllDriversAllData()
        {
            return clsDriversDataAccess.GetAllDrivers(clsDriversDataAccess.enMode.PersonJoined);
        }
        public static DataTable GetAllDriversFiltered(int DriverID = -1, int PersonID = -1, 
            string Fullname = "", string NationalNo = "")
        {
            return clsDriversDataAccess.GetDriversFiltered(DriverID, PersonID, NationalNo, Fullname);
        }
        public static DataTable GetallDriversSimpled()
        {
            return clsDriversDataAccess.GetAllDriversSimple();
        }
        public static string GetDriverFullName(int DriverID)
        {
            clsDrivers driver = Find(DriverID: DriverID);

            if (driver != null)
                return GetPersonFullName(driver.PersonID);
            else
                return "";
        }

        private bool _AddNewDriver()
        {

            this.DriverID = clsDriversDataAccess.AddDriver(PersonID, CreatedByUserID, CreatedDate);
            return (this.DriverID != -1);
  
        }
        private bool _UpdateDriver()
        {
            return clsDriversDataAccess.UpdateDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
        }
        private bool _AddNewDriver_PersonNotExists()
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


            if (person.Save())
            {
                this.DriverID = clsDriversDataAccess.AddDriver(PersonID, CreatedByUserID, CreatedDate);
                return (this.DriverID != -1);
            }
            return false;
        }
        private bool _UpdateDriver_PersonNotExists()
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
                return clsDriversDataAccess.UpdateDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }

            return false;
        }

        public new bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewDriver())
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
                return (_UpdateDriver());
            }
        }
        public bool Save_PersonNotExists()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewDriver_PersonNotExists())
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
                return (_UpdateDriver_PersonNotExists());
            }
        }

    }
}
