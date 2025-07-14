using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsApplications
    {
        public int ApplicationID { get; set; }
        public int PersonID {  get; set; }
        public DateTime? ApplicationDate { get; set; }
        public int ApplicationType { get; set; }
        public short ApplicationStatus { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        private enum enMode { eAdd, eUpdate }
        private enMode Mode;

        public clsApplications()
        {
            ApplicationID = -1;
            PersonID = -1;
            ApplicationDate = null;
            ApplicationType = -1;
            ApplicationStatus = -1;
            LastStatusDate = null;
            PaidFees = -1;
            CreatedByUserID = -1;

            Mode = enMode.eAdd;
        }
        
        private clsApplications(int ApplicationID,  int PersonID,
            DateTime? ApplicationDate, int ApplicationType, short ApplicationStatus,
            DateTime? LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.PersonID = PersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationType = ApplicationType;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.eUpdate;
        }


    }
}
