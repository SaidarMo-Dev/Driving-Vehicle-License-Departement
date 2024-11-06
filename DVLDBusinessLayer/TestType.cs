using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;

namespace DVLDBusinessLayer
{
    public class clsTestType
    {

        enum enMode { AddNew = 1, Update = 2 };
        public enum enTestType { VisionTest = 1, WriteenTest = 2, StreetTest = 3 };

        private enMode _Mode ;

       
        public int TestTypeID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public double Fees { set; get; }

        public clsTestType()
        {
            this.TestTypeID = -1;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;

        }
        private clsTestType(int ID , string Title , string Description, double Fees)
        {
            this.TestTypeID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;


        }

        public static clsTestType GetTestType(int ID)
        {
            string Title = "";
            string Description = "";
            double Fees = 0;

            if (clsTestTypes.GetTestType(ID,ref Title, ref Description, ref Fees))
            {
                return new clsTestType(ID, Title, Description, Fees);
            }
            return null;
        }

        public bool UpdateTestType()
        {
            return clsTestTypes.UpdateTestType(this.TestTypeID, this.Title, this.Description, this.Fees);
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypes.GetListTestTypes();
        }
    }
}
