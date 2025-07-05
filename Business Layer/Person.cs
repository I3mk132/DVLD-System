using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string NationalNo {  get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public string Thirdname { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public short Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string ImagePath { get; set; }
        protected enum enMode { AddNew, Update }
        private enMode _Mode;

        public clsPerson()
        {
            PersonID = -1;
            NationalNo = "";
            Firstname = "";
            Secondname = "";
            Thirdname = "";
            Lastname = "";
            DateOfBirth = null;
            Gender = -1;
            Address = "";
            Phone = "";
            Email = "";
            Country = "";
            ImagePath = "";

            _Mode = enMode.AddNew;
        }

        protected clsPerson(

            int PersonID,
            string NationalNo, 
            string Firstname, 
            string Secondname, 
            string Thirdname,
            string Lastname, 
            DateTime? DateOfBirth, 
            short Gender, 
            string Address, 
            string Phone,
            string Email, 
            string Country, 
            string ImagePath

            )
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.Firstname = Firstname;
            this.Secondname = Secondname;
            this.Thirdname = Thirdname;
            this.Lastname = Lastname;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.Country = Country;
            this.ImagePath = ImagePath;

            _Mode = enMode.Update;
        }

        public static clsPerson Find(
            int PersonID = -1, string NationalNo = "", string Firstname = "", 
            string Secondname = "", string Thirdname = "", string Lastname = "", 
            DateTime? DateOfBirth = null, short Gender = -1, string Address = "", 
            string Phone = "", string Email = "", string Country = "", string ImagePath = ""
        )
        {


            if (clsPersonDataAccess.GetPerson(
                ref PersonID, ref NationalNo, ref Firstname, ref Secondname, ref Thirdname,
                ref Lastname, ref DateOfBirth, ref Gender, ref Address, ref Phone,
                ref Email, ref Country, ref ImagePath)
                )
            {
                return new clsPerson(
                    PersonID, NationalNo, Firstname, Secondname, Thirdname,
                    Lastname, DateOfBirth, Gender, Address,  Phone,
                    Email, Country, ImagePath);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetPeopleWith(
            int PersonID = -1, string NationalNo = "", string Firstname = "",
            string Secondname = "", string Thirdname = "", string Lastname = "",
            DateTime? DateOfBirth = null, short Gender = -1, string Address = "",
            string Phone = "", string Email = "", string Country = "", string ImagePath = ""
        )
        {
            return clsPersonDataAccess.GetPeople(
                PersonID, NationalNo, Firstname, Secondname, Thirdname,
                Lastname, DateOfBirth, Gender, Address, Phone,
                Email, Country, ImagePath);
        }
        public static bool isPersonExists(int ID)
        {
            return clsPersonDataAccess.IsPersonExists(ID);
        }
        public static bool DeletePerson(int ID)
        {
            return (clsPersonDataAccess.DeletePerson(ID));
        }
        public static DataTable GetAllPerson()
        {
            return clsPersonDataAccess.GetAllPerson();
        }


        public static string GetPersonFullName(int ID)
        {

            clsPerson person = clsPerson.Find(PersonID: -1);
            return person.Firstname + " " + person.Secondname + " " + person.Thirdname + " " + person.Lastname;

        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccess.AddPerson(
                NationalNo, Firstname, Secondname, Thirdname,
                Lastname, DateOfBirth, Gender, Address, 
                Phone, Email, Country, ImagePath);

            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPersonDataAccess.UpdatePerson(
                PersonID, NationalNo, Firstname, Secondname, 
                Thirdname, Lastname, DateOfBirth, Gender, 
                Address, Phone, Email, Country, ImagePath);
        }
        public bool Save()
        {

            if (_Mode == enMode.AddNew)
            {
                if (_AddNewPerson())
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
                return _UpdatePerson();
            }
                    
        }

    }
}
