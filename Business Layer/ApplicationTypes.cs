using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class clsApplicationTypes
    {
        public int ID { get; set; }
        public string ApplicationType {  get; set; }
        public decimal Fees {  get; set; }

        public clsApplicationTypes()
        {
            ID = -1;
            ApplicationType = string.Empty;
            Fees = -1;
        }
        private clsApplicationTypes(int ID,  string ApplicationType, decimal Fees)
        {
            this.ID = ID;
            this.ApplicationType = ApplicationType;
            this.Fees = Fees;
        }

        public static clsApplicationTypes Find(int ID)
        {
            string ApplicationType = "";
            decimal Fees = -1;
            if (clsApplicationTypesDataAccess.GetApplicationType(ref ID, ref ApplicationType, ref Fees))
            {
                return new clsApplicationTypes(ID, ApplicationType, Fees);
            }
            return null;
        }
        public static DataTable GetApplicationTypesList()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }
        
        public bool Update()
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType(ID, ApplicationType, Fees);
        }

    }
}
