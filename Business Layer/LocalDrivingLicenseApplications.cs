using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsLocalDrivingLicenseApplications : clsApplications
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public string LicenseClassName
        {
            get => clsLicenseClassesDataAccess.GetLicenseClassNameByID(LicenseClassID);
            set => LicenseClassID = clsLicenseClassesDataAccess.GetLicenseClassIDByName(value);
        }
        

        private enum enMode { eAdd, eUpdate }
        private enMode Mode;

        public clsLocalDrivingLicenseApplications() : base ()
        {
            LocalDrivingLicenseApplicationID = -1;
            LicenseClassID = -1;

            Mode = enMode.eAdd;
        }

        private clsLocalDrivingLicenseApplications(
            int LocalDrivingLicenseApplicationID,
            int ApplicationID, 
            int PersonID,
            DateTime? ApplicationDate, 
            int ApplicationTypeID, 
            string ApplicationStatus,
            DateTime? LastStatusDate, 
            decimal PaidFees, 
            int CreatedByUserID,
            int LicenseClassID) : base (
                
                ApplicationID, PersonID, ApplicationDate, ApplicationTypeID,
                ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID

                )
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;

            Mode = enMode.eUpdate;
        }

        public static new clsLocalDrivingLicenseApplications Find(
            int LocalDrivingLicenseApplicationID
        )
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationsDataAccess.Find(
                ref LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID)
                )
            {
                clsApplications app = clsApplications.Find(ApplicationID);

                return new clsLocalDrivingLicenseApplications(
                    LocalDrivingLicenseApplicationID, ApplicationID, app.PersonID, app.ApplicationDate, 
                    app.ApplicationTypeID, app.ApplicationStatus, app.LastStatusDate, 
                    app.PaidFees, app.CreatedByUserID , LicenseClassID);
            }
            else
            {
                return null;
            }
        }



        public static DataTable GetAll()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAll();
        }
        public static DataTable GetAllFiltered(
            int LocalDrivingLicenseApplicationID = -1, string NationalNo = "", string Fullname = "", string Status = ""
        )
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAllFiltered(
                LocalDrivingLicenseApplicationID, NationalNo, Fullname, Status);
        }

        public static List<string> GetAllLicenseClasses()
        {
            return clsLicenseClassesDataAccess.GetAllLicenseClassNames();
        }

        public bool CancelApplication()
        {
            if (Mode == enMode.eUpdate)
            {
                return clsApplicationsDataAccess.ChangeStatusToCancel(this.ApplicationID);
            }
            return false;
        }

        public static new bool Delete(int ID)
        {
            clsLocalDrivingLicenseApplications app = clsLocalDrivingLicenseApplications.Find(ID);
            if (clsLocalDrivingLicenseApplicationsDataAccess.Delete(ID))
            {
                return clsApplications.Delete(app.ApplicationID);
            }
            return false;
        }

        public static bool IsApplicationExists(int PersonID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.IsExists(PersonID, LicenseClassID);
        }

        private bool _AddNew()
        {
            clsApplications app = new clsApplications();

            app.PersonID = PersonID;
            app.ApplicationDate = ApplicationDate;
            app.ApplicationTypeID = ApplicationTypeID;
            app.ApplicationStatus = ApplicationStatus;
            app.LastStatusDate = LastStatusDate;
            app.PaidFees = PaidFees;
            app.CreatedByUserID = CreatedByUserID;

            if (app.Save())
            {
                this.ApplicationID = clsLocalDrivingLicenseApplicationsDataAccess.Add(
                app.ApplicationID, LicenseClassID);

                return (this.ApplicationID != -1);
            }
            return false;
        }
        private bool _Update()
        {

            clsApplications app = clsApplications.Find(ApplicationID);

            app.PersonID = PersonID;
            app.ApplicationDate = ApplicationDate;
            app.ApplicationTypeID = ApplicationTypeID;
            app.ApplicationStatus = ApplicationStatus;
            app.LastStatusDate = LastStatusDate;
            app.PaidFees = PaidFees;
            app.CreatedByUserID = CreatedByUserID;
            
            if (app.Save())
                return clsLocalDrivingLicenseApplicationsDataAccess.Update(
                    LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            return false;
        }

        public new bool Save()
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
