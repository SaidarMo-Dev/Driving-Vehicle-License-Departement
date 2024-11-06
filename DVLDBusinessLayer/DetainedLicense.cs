using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;

namespace DVLDBusinessLayer
{
    public class DetainedLicense
    {
        enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode;

        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public clsLicense LicenseInfo { set; get; }
        public DateTime DetainDate { set; get; }
        public double FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public User CreatedByUserInfo{ set; get; }

        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public User ReleasedByUserInfo { set; get; }
        public int ReleaseApplicationID { set; get; }



        public DetainedLicense ()
        {
            this._Mode = enMode.AddNew;

            this.DetainID = -1;
            this.LicenseID = -1;
            this.LicenseInfo = new clsLicense();
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.CreatedByUserInfo = new User();

            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this. ReleasedByUserID = -1;
            this.ReleasedByUserInfo = new User();
            this.ReleaseApplicationID = -1;


        }

        private DetainedLicense(int DetainID, int LicenseID, DateTime DetainDate,
                         double FineFees, int CreatedByUserID, bool IsReleased,
                         DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this._Mode = enMode.Update;

            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.LicenseInfo = clsLicense.GetLicenseInfoBylicenseID(LicenseID);
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = User.GetUserByID(CreatedByUserID);

            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleasedByUserInfo = User.GetUserByID(ReleasedByUserID);
            this.ReleaseApplicationID = ReleaseApplicationID;


        }



        public static DetainedLicense GetDetainedLicenseInfoByDetainID(int DetainID)
        {
           
            int LicenseID = -1;
            DateTime DetainDate = DateTime .Now;
            double FineFees = 0;
            int CreatedByUserID = -1;

            bool IsReleased = false ;
            DateTime ReleaseDate = DateTime .Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicenseDataAccess .GetDetainedLicenseInfoByDetainID(DetainID,ref LicenseID,
                                    ref DetainDate,ref FineFees ,ref CreatedByUserID ,ref IsReleased ,
                                    ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new DetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                                          IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }

            return null;

        }

        public static DetainedLicense GetDetainedLicenseInfoByLicenseID(int LicenseID)
        {

            int DetainID = -1;

            DateTime DetainDate = DateTime.Now;
            double FineFees = 0;
            int CreatedByUserID = -1;

            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicenseDataAccess.GetDetainedLicenseInfoByLicenseID(LicenseID, ref DetainID,
                                    ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased,
                                    ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new DetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                                          IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }

            return null;

        }



        private bool _AddNewDetainedLicense()
        {
            this.DetainID =  clsDetainedLicenseDataAccess.AddDetainedLicenseInfo(this.LicenseID, this.DetainDate,
                             this.FineFees, this.CreatedByUserID);

            return (this.DetainID != -1);

        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseDataAccess.UpdateDetainedLicenseInfo(this.DetainID, this.ReleaseDate,
                this.ReleasedByUserID, this.ReleaseApplicationID);

        }



        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicenseDataAccess.IsLicenseDetained(LicenseID);
        }

        public static DataTable GetListDetainedLicenses()
        {
            return clsDetainedLicenseDataAccess.GetListDetainedLicenses();
        
        }

        public bool Save()
        {
            switch (this ._Mode )
            {
                case enMode .AddNew :
                    if(_AddNewDetainedLicense())
                    {
                        this._Mode = enMode.Update;

                        return true;
                    }
                    return false;

                case  enMode.Update :
                    return _UpdateDetainedLicense();

                default :
                    return false;
            }
        }
  
    
    }
}
