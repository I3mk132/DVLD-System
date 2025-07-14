using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsLocalDrivingLicenseApplications
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        private enum enMode { eAdd, eUpdate }
        private enMode Mode;

        public clsLocalDrivingLicenseApplications()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = -1;

            Mode = enMode.eAdd;
        }

        private clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int LIcenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;

            Mode = enMode.eUpdate;
        }

        public static clsLocalDrivingLicenseApplications Find(
            int LocalDrivingLicenseApplicationID
        )
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationsDataAccess.Find(
                ref LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID)
                )
            {
                return new clsLocalDrivingLicenseApplications(
                    LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAll()
        {
            return clsLocalDrivingLicenseApplications.GetAll();
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

        public static bool Delete(int ID)
        {
            return  clsLocalDrivingLicenseApplicationsDataAccess.Delete(ID);
        }
        private bool _AddNew()
        {
            this.ApplicationID = clsLocalDrivingLicenseApplicationsDataAccess.Add(
                ApplicationID, LicenseClassID);

            return (this.ApplicationID != -1);
        }
        private bool _Update()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.Update(
                LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
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
