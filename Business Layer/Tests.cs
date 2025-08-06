using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;
using static System.Net.Mime.MediaTypeNames;

namespace Business_Layer
{
    public class clsTests
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        private enMode _Mode { get; set; }
        private enum enMode { eAdd, eUpdate }


        public clsTests()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUserID = -1;


            _Mode = enMode.eAdd;
        }

        private clsTests(
            int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID
            )
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;

            _Mode = enMode.eUpdate;
        }

        public static DataTable GetAll()
        {
            return clsTestsDataAccess.GetAll();
        }
        public static int GetTrialsCount(int LDLAppID, int TestType)
        {
            return clsTestsDataAccess.TrialCount( LDLAppID, TestType );
        }
        public static clsTests Find(
            int TestID
        )
        {
            int TestAppointmentID = -1, CreatedByUserID = -1;
            bool TestResult = false;
            string Notes = "";

            if (clsTestsDataAccess.Find(ref TestID, ref TestAppointmentID, ref TestResult,
                ref Notes, ref CreatedByUserID))
            {
                return new clsTests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }

            return null;
        }

        public static bool Delete(int ID)
        {
            return clsTestsDataAccess.Delete(ID);
        }

        private bool _AddNew()
        {

            this.TestID = clsTestsDataAccess.Add(TestAppointmentID, TestResult, Notes, CreatedByUserID);
            return (this.TestID != -1) && clsTestAppointments.LockAppointment(TestAppointmentID); ;

        }
        private bool _Update()
        {
            return clsTestsDataAccess.Update(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
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
