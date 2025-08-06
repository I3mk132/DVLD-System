using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsTestAppointments 
    {
        public int TestAppointmentID {  get; set; }
        public int TestTypeID { get; set; }
        public string TestType
        {
            get => clsTestTypes.Find(TestTypeID).Title;
            set => TestTypeID = clsTestTypes.Find(Title: value).ID;
        }
        public decimal TestFees
        {
            get => clsTestTypes.Find(TestTypeID).Fees;
        }
        public int LDLAppID { get; set; }
        public DateTime? AppointmentDate {  get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool? IsLocked { get; set; }
        public int RetakeTestAppointmentID { get; set; }
        private enMode _Mode {  get; set; }
        private enum enMode { eAdd, eUpdate }

        public string ClassName => clsLocalDrivingLicenseApplications.Find(LDLAppID).LicenseClassName;
        
        public string Fullname
        {
            get => clsLocalDrivingLicenseApplications.Find(LDLAppID).Fullname;
        }
        public int TrialCount
        {
            get => clsTests.GetTrialsCount(LDLAppID, TestTypeID);
        }

        public clsTestAppointments() 
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LDLAppID = -1;
            AppointmentDate = null;
            PaidFees = -1;
            CreatedByUserID = -1;
            IsLocked = null;
            RetakeTestAppointmentID = -1;

            _Mode = enMode.eAdd;
        }

        private clsTestAppointments(

            int TestAppointmentID, int TestTypeID, int LDLAppID, DateTime? AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool? IsLocked, int RetakeTestAppointmentID

            ) 
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDLAppID = LDLAppID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestAppointmentID = RetakeTestAppointmentID;

            _Mode = enMode.eUpdate;
        }

        public static DataTable GetAllTestAppointmentsFor(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetAllFor(LDLAppID, TestTypeID);
        }
        public static clsTestAppointments Find(
            int TestAppointmentID
        )
        {
            int TestTypeID = -1, LDLAppID = -1, CreatedByUserID = -1, RetakeTestAppointmentID = -1;
            DateTime? AppointmentDate = null;
            decimal PaidFees = -1;
            bool? IsLocked = null;

            if (clsTestAppointmentsDataAccess.Find(ref TestAppointmentID, ref TestTypeID, ref LDLAppID, ref AppointmentDate,
            ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppointmentID))
            {
                return new clsTestAppointments(TestAppointmentID,  TestTypeID, LDLAppID, AppointmentDate, 
                    PaidFees,  CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            }

            return null;
        }
        public static clsTestAppointments FindWithLDLAppID(int LDLAppID)
        {
            int TestTypeID = -1, TestAppointmentID = -1, CreatedByUserID = -1, RetakeTestAppointmentID = -1;
            DateTime? AppointmentDate = null;
            decimal PaidFees = -1;
            bool? IsLocked = null;

            if (clsTestAppointmentsDataAccess.FindUsingLDLAppID(ref TestAppointmentID, ref TestTypeID, ref LDLAppID, ref AppointmentDate,
            ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestAppointmentID))
            {
                return new clsTestAppointments(TestAppointmentID, TestTypeID, LDLAppID, AppointmentDate,
                    PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            }

            return null;
        }

        public static int IsRetakeAppointment(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.IsRetakeAppointment(LDLAppID, TestTypeID);
        }
        public static bool HasUnlockedAppointment(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.CheckForUnlockedTest(LDLAppID, TestTypeID);
        }
        public static bool LockAppointment(int AppointmentID)
        {
            return clsTestAppointmentsDataAccess.LockAppointment(AppointmentID);
        }

        public static bool IsExists(int ID)
        {
            return clsTestAppointmentsDataAccess.IsExists(ID);
        }
        public static bool Delete(int ID)
        {
            return clsTestAppointmentsDataAccess.Delete(ID);
        }

        private bool _AddNew()
        {

            this.TestAppointmentID = clsTestAppointmentsDataAccess.Add(TestTypeID, LDLAppID, AppointmentDate, 
                PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            return (this.TestAppointmentID != -1);
            
        }
        private bool _Update()
        {

            return clsTestAppointmentsDataAccess.Update(TestAppointmentID, TestTypeID, 
                LDLAppID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);

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
