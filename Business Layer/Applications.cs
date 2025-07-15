using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsApplications
    {
        public int ApplicationID { get; set; }
        public int PersonID {  get; set; }
        public DateTime? ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public string ApplicationStatus { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public int CreatedByUsername
        {
            get => 
        }
        private enum enMode { eAdd, eUpdate }
        private enMode Mode;

        public clsApplications()
        {
            ApplicationID = -1;
            PersonID = -1;
            ApplicationDate = null;
            ApplicationTypeID = -1;
            ApplicationStatus = "";
            LastStatusDate = null;
            PaidFees = -1;
            CreatedByUserID = -1;

            Mode = enMode.eAdd;
        }
        
        protected clsApplications(int ApplicationID,  int PersonID,
            DateTime? ApplicationDate, int ApplicationTypeID, string ApplicationStatus,
            DateTime? LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.PersonID = PersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.eUpdate;
        }

        public static clsApplications Find(
            int ApplicationID
        )
        {
            int PersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            DateTime? ApplicationDate = null, LastStatusDate = null;
            string ApplicationStatus = "";
            decimal PaidFees = -1;

            if (clsApplicationsDataAccess.Find(
                ref ApplicationID, ref PersonID,
                ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus,
                ref LastStatusDate, ref PaidFees, ref CreatedByUserID)
                )
            {
                return new clsApplications(
                    ApplicationID, PersonID,
                    ApplicationDate, ApplicationTypeID, ApplicationStatus,
                    LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int ID)
        {
            return clsApplicationsDataAccess.Delete(ID);
        }

        private bool _AddNew()
        {
            this.ApplicationID = clsApplicationsDataAccess.Add(
                PersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return (this.ApplicationID != -1);
        }
        private bool _Update()
        {
            return clsApplicationsDataAccess.Update(
                ApplicationID, PersonID, ApplicationDate, ApplicationTypeID, 
                ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
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
