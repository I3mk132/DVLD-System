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
    public class clsTestTypes
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }

        public clsTestTypes()
        {
            ID = -1;
            Title = string.Empty;
            Description = string.Empty;
            Fees = -1;
        }
        private clsTestTypes(int ID, string Title, string Description, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;
        }

        public static clsTestTypes Find(int ID)
        {
            string Title = "", Description = "";
            decimal Fees = -1;
            if (clsTestTypesDataAccess.GetTestType(ref ID, ref Title, ref Description, ref Fees))
            {
                return new clsTestTypes(ID, Title, Description, Fees);
            }
            return null;
        }
        public static clsTestTypes Find(string Title)
        {
            string Description = "";
            decimal Fees = -1;
            int ID = -1;

            if (clsTestTypesDataAccess.GetTestTypeByTitle(ref ID, ref Title, ref Description, ref Fees))
                return new clsTestTypes(ID, Title, Description, Fees);
            return null;
        }
        public static DataTable GetTestTypesList()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }

        public bool Update()
        {
            return clsTestTypesDataAccess.UpdateTestType(ID, Title, Description, Fees);
        }

    }
}
