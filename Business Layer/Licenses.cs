using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsLicenses
    {
        public int LicenseID {  get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID  { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool? IsActive { get; set; }
        public string IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public bool? IsDetained
        {
            get
            {
                return false; // Temp until detain system be added . 
            }
            set
            {
                IsDetained = value;
            }
        }
        public string LicenseClassName
        {
            get => clsLicenseClassesDataAccess.GetLicenseClassNameByID(LicenseClassID);
            set => LicenseClassID = clsLicenseClassesDataAccess.GetLicenseClassIDByName(value);
        }
        public string Fullname
        {
            get => clsDrivers.GetDriverFullName(DriverID);
        }
        public string NationalNo
        {
            get => clsDrivers.Find(DriverID).NationalNo;
        }
        public string Gender
        {
            get => clsDrivers.Find(DriverID).Gender;
        }
        public DateTime? DateOfBirth
        {
            get => clsDrivers.Find(DriverID).DateOfBirth;
        }
        public string ImagePath
        {
            get => clsDrivers.Find(DriverID).ImagePath;
        }

        private enMode _Mode { get; set; }
        private enum enMode { eAdd, eUpdate }


        public clsLicenses()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = null;
            ExpirationDate = null;
            Notes = "";
            PaidFees = -1;
            IsActive = null;
            IssueReason = null;
            CreatedByUserID = -1;


            _Mode = enMode.eAdd;
        }

        private clsLicenses(

            int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, 
            DateTime? IssueDate, DateTime? ExpirationDate,
            string Notes, decimal PaidFees, bool? IsActive, string IssueReason, int CreatedByUserID

            )
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.eUpdate;
        }

        public static DataTable GetAll()
        {
            return clsLicensesDataAccess.GetAll();
        }
        public static DataTable GetAllFor(int PersonID)
        {
            return clsLicensesDataAccess.GetAllLocalFor(PersonID);
        }
        public static clsLicenses Find(
            int LicenseID
        )
        {
            int ApplicationID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime? IssueDate = null, ExpirationDate = null;
            string Notes = "", IssueReason = "";
            decimal PaidFees = -1;
            bool? IsActive = null;

            if (clsLicensesDataAccess.Find(ref LicenseID, ref ApplicationID, ref DriverID, 
                ref LicenseClassID, ref IssueDate, ref ExpirationDate, 
                ref Notes, ref PaidFees, ref IsActive, 
                ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate,
                    ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }

            return null;
        }
        public static clsLicenses FindByAppID(int ApplicationID)
        {
            int DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1, LicenseID = -1;
            DateTime? IssueDate = null, ExpirationDate = null;
            string Notes = "", IssueReason = "";
            decimal PaidFees = -1;
            bool? IsActive = null;

            if (clsLicensesDataAccess.FindByAppID(ref LicenseID, ref ApplicationID, ref DriverID,
                ref LicenseClassID, ref IssueDate, ref ExpirationDate,
                ref Notes, ref PaidFees, ref IsActive,
                ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenses(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate,
                    ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }

            return null;
        }

        public static bool Delete(int ID)
        {
            return clsLicensesDataAccess.Delete(ID);
        }

        private bool _AddNew()
        {

            this.LicenseID = clsLicensesDataAccess.Add(ApplicationID, DriverID, LicenseClassID, 
                IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            return (this.LicenseID != -1);

        }
        private bool _Update()
        {

            return clsLicensesDataAccess.Update(LicenseID, ApplicationID, 
                DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, 
                PaidFees, IsActive, IssueReason, CreatedByUserID);

        }
        public bool Save()
        {

            if (_Mode == enMode.eAdd)
            {
                if (_AddNew())
                {
                    _Mode = enMode.eUpdate;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return (_Update());
            }
        }
    }
}
