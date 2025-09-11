using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsDetainedLicenses
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime? DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID {  get; set; }
        private enMode _Mode { get; set; }
        private enum enMode { eAdd, eUpdate }

        public clsDetainedLicenses()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = null;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = null;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;

            _Mode = enMode.eAdd;
        }
        private clsDetainedLicenses(
                int DetainID,
                int LicenseID,
                DateTime? DetainDate,
                decimal FineFees,
                int CreatedByUserID,
                bool IsReleased,
                DateTime? ReleaseDate,
                int ReleasedByUserID,
                int ReleaseApplicationID
            )
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate.Value;
            this.FineFees = FineFees; 
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            _Mode = enMode.eUpdate;
        }
        public static DataTable GetAll()
        {
            return clsDetainedLicensesDataAccess.GetAll();
        }
        public static clsDetainedLicenses Find(
            int DetainID
        )
        {
            int LicenseID = -1, CreatedByUserID = -1,
                ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime? DetainDate = null, ReleaseDate = null;
            bool IsReleased = false ;
            decimal FineFees = -1;

            if (clsDetainedLicensesDataAccess.Find(
                ref DetainID, ref LicenseID, ref DetainDate, 
                ref FineFees, ref CreatedByUserID, 
                ref IsReleased, ref ReleaseDate, 
                ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(DetainID, LicenseID, DetainDate, FineFees, 
                    CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }

            return null;
        }

        public static bool Delete(int ID)
        {
            return clsDetainedLicensesDataAccess.Delete(ID);
        }

        private bool _AddNew()
        {

            this.DetainID = clsDetainedLicensesDataAccess.Add(
                LicenseID, DetainDate, FineFees ,CreatedByUserID, 
                IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            return (this.DetainID != -1);

        }
        private bool _Update()
        {
            return clsDetainedLicensesDataAccess.Update(
                DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, 
                IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
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
