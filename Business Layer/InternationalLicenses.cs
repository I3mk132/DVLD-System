using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using static System.Net.Mime.MediaTypeNames;

namespace Business_Layer
{
    public class clsInternationalLicenses
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID {  get; set; }
        public int IssuedUsingLocalLicenseID {  get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        private enum enMode { eAdd, eUpdate }
        private enMode Mode { get; set; }

        public clsLicenses LocalLicense { get; private set; }

        public clsInternationalLicenses()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = null;
            ExpirationDate = null;
            IsActive = false;
            CreatedByUserID = -1;


            Mode = enMode.eAdd;
        }

        private clsInternationalLicenses(

                int InternationalLicenseID, int ApplicationID, int DriverID,
                int IssuedUsingLocalLicenseID, DateTime? IssueDate, 
                DateTime? ExpirationDate, bool IsActive, 
                int CreatedByUserID

            )
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            LocalLicense = clsLicenses.Find(IssuedUsingLocalLicenseID);
            Mode = enMode.eUpdate;
        }


        public static DataTable GetAll()
        {
            return clsInternationalLicensesDataAccess.GetAll();
        }
        public static DataTable GetAllFiltered(int InternationalLicenseID = -1, string NationalNo = "", string Fullname = "")
        {
            return clsInternationalLicensesDataAccess.GetAllFiltered(InternationalLicenseID, NationalNo, Fullname);
        }
        public static DataTable GetAllFor(int PersonID)
        {
            return clsInternationalLicensesDataAccess.GetAllFor(PersonID);
        }
        public static clsInternationalLicenses Find(int ID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1,
                CreatedByUserID = -1;
            DateTime? IssueDate = null, ExpirationDate = null;
            bool IsActive = false;

            if (clsInternationalLicensesDataAccess.Find(
                ref ID, ref ApplicationID, ref DriverID, 
                ref IssuedUsingLocalLicenseID, ref IssueDate, 
                ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicenses(
                    ID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                    IssueDate, ExpirationDate, IsActive, CreatedByUserID
                    );
                    
            }
            return null;

        }
        public static bool Delete(int ID)
        {
            return clsInternationalLicensesDataAccess.Delete(ID);
        }

        private bool _AddNew()
        {
            this.InternationalLicenseID = clsInternationalLicensesDataAccess.Add(
                ApplicationID, DriverID, 
                IssuedUsingLocalLicenseID, IssueDate, 
                ExpirationDate, IsActive, CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }
        private bool _Update()
        {
            return clsInternationalLicensesDataAccess.Update(
                InternationalLicenseID, ApplicationID, DriverID,
                IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                IsActive, CreatedByUserID);
        }

        public bool Save()
        {

            if (Mode == enMode.eAdd)
            {
                if (_AddNew())
                {
                    Mode = enMode.eUpdate;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return _Update();
            }

        }
    }
}
