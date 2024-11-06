using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;

namespace DVLDBusinessLayer
{
    public class LicenseClass
    {

        public int LicenseClassID { set; get; }
        public string LicenseClassName { set; get; }
        public string LicenseClassDescription { set; get; }
        public int MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public double LicenseClassFess { set; get; }

        public LicenseClass()
        {
            this.LicenseClassID = -1;
            this.LicenseClassName = "";
            this.LicenseClassDescription = "";
            this.MinimumAllowedAge = -1;
            this.DefaultValidityLength = 0;
            this.LicenseClassFess = 0;


        }

        private LicenseClass(int LicenseClassID, string LicenseClassName, string LicenseClassDescription,
                              int MinimumAllowedAge, byte VailidityLength, double Fees )
        {
            this.LicenseClassID = LicenseClassID ;
            this.LicenseClassName = LicenseClassName ;
            this.LicenseClassDescription = LicenseClassDescription ;
            this.MinimumAllowedAge = MinimumAllowedAge ;
            this.DefaultValidityLength = VailidityLength;
            this.LicenseClassFess = Fees ;
        }



        public static DataTable ListLicenseClasses()
        {
            return clsLicenseClassDataAccess.GetListLicenseClasses();
            
        }

        public static LicenseClass GetLicenseClassInfoByID(int LicenseClassID)
        {
          

            string LicenseClassName = "";
            string LicenseClassDescription = "";
            int MinimumAllowedAge = -1;
            byte DefaultValidityLength = 0;
            double LicenseClassFess = 0;

            if (clsLicenseClassDataAccess.GetLicenseClassInfoByID(LicenseClassID, ref LicenseClassName, ref LicenseClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref LicenseClassFess))
            {
                return new LicenseClass(LicenseClassID, LicenseClassName, LicenseClassDescription,
                                        MinimumAllowedAge, DefaultValidityLength, LicenseClassFess);
            }

            return null;
        }

        public static LicenseClass GetLicenseClassInfoByName(string ClassName)
        {


            int LicenseClassID = -1;
            string LicenseClassDescription = "";
            int MinimumAllowedAge = -1;
            byte DefaultValidityLength = 0;
            double LicenseClassFess = 0;

            if (clsLicenseClassDataAccess.GetLicenseClassInfoByName(ClassName, ref LicenseClassID, ref LicenseClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref LicenseClassFess))
            {
                return new LicenseClass(LicenseClassID ,ClassName, LicenseClassDescription,
                                        MinimumAllowedAge, DefaultValidityLength, LicenseClassFess);
            }

            return null;
        }
   

    }
}
