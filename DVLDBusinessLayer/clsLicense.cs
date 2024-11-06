using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;

namespace DVLDBusinessLayer
{
    public class clsLicense
    {

        //enum enMode { AddNew = 1, Update = 2 };
        public enum enIssueReason { FirstTime = 1, Renew = 2, ReplacementForDamaged = 3, ReplacementForLost = 4 };
      //  private enMode _Mode;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo { get; set; }
        public int DriverID {get;set;}
        public Driver DriverInfo { get; set; } 
        public int LicenseClassID { get; set; }
        public LicenseClass LicenseClassInfo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public double PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public string IssuereasonToString
        {
            get
            {
                switch (this .IssueReason)
                {
                    case enIssueReason .FirstTime :
                        return "First Time";
                        
                    case enIssueReason .Renew :
                        return "Renew";
                        
                    case enIssueReason .ReplacementForDamaged :
                        return "Replacement For Damaged";
                        

                    case enIssueReason .ReplacementForLost :
                        return "Replacement For Lost";
                        
                    default :
                        return "";
                }
            }
        }
        public int CreatedBuyUserID { get; set; }
        public User CreatedByUserInfo { get; set; }


        public clsLicense()
        {
           // this._Mode = enMode.AddNew;

            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.ApplicationInfo = new clsApplication();
            this.DriverID = -1;
            this.DriverInfo = new Driver();
            this.LicenseClassID = -1;
            this.LicenseClassInfo = new LicenseClass();
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this .PaidFees = 0;
            this.IsActive = false;
            this .IssueReason = enIssueReason .FirstTime;
            this .CreatedBuyUserID = -1;
            this.CreatedByUserInfo = new User(); 




        }


        private clsLicense(int LicenseID, int ApplicationID, int DriverID,
                     int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,
                     string Notes, double PaidFees, bool IsActive, enIssueReason IssueReason,
                     int CreatedByUserID)
        {
            //this._Mode = enMode.Update;

            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.GetApplicationInfoByID(ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = Driver.GetDriverInfo(DriverID);
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = LicenseClass.GetLicenseClassInfoByID(LicenseClassID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedBuyUserID = CreatedBuyUserID;
            this.CreatedByUserInfo = User.GetUserByID(CreatedBuyUserID);




        }



        public static clsLicense GetLicenseInfoBylicenseID(int LicenseID)
        {

          
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime  ExpirationDate = DateTime.Now;
            string Notes = "";
            double PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 1;
            int CreatedBuyUserID = -1;
            
            if (clsLicenseDataAccess.GetLicenseInfoByLicenseID(LicenseID, ref ApplicationID , ref DriverID, 
                        ref LicenseClassID , ref IssueDate , ref ExpirationDate ,ref Notes , ref PaidFees ,
                        ref IsActive , ref IssueReason , ref CreatedBuyUserID ))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID,
                         LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees,
                         IsActive, (enIssueReason)IssueReason, CreatedBuyUserID);
            }

            return null;
        }



        public static clsLicense GetLicenseInfoByApplicationID(int ApplicationID)
        {


            int LicenseID = -1;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            double PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 1;
            int CreatedBuyUserID = -1;

            if (clsLicenseDataAccess.GetLicenseInfoByApplicationID(ApplicationID,ref LicenseID, ref DriverID,
                        ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees,
                        ref IsActive, ref IssueReason, ref CreatedBuyUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID,
                         LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees,
                         IsActive,(enIssueReason)IssueReason, CreatedBuyUserID);
            }

            return null;
        }


        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseDataAccess.AddNewLicense(this.ApplicationID, this.DriverID,
                    this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes,
                    this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedBuyUserID);


            return (this.LicenseID) != -1;
        }

        public static bool IsLicenseExisteByLicenseID(int LicenseID)
        {
            return clsLicenseDataAccess.IsLicenseExisteByLicenseID(LicenseID);

        }

        public static bool IsLicenseExisteByApplicationID(int  ApplicationID)
        {
            return clsLicenseDataAccess.IsLicenseExisteByApplicationID(ApplicationID);
        }
         
        public  bool Save()
        {
            return _AddNewLicense();
        }


        public static DataTable LoadPersonLicenses(int PersonID)
        {
            return clsLicenseDataAccess.LoadDriverLicenses(Driver.GetDriverInfoByPesonID(PersonID).DriverID);
        }

        public bool IsLicenseActive()
        {
            return clsLicenseDataAccess.IsLicenseActive(this.LicenseID);
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            return clsLicenseDataAccess.IsLicenseActive(LicenseID);
        }

        public static int GetDriverID(int LicenseID)
        {
            return clsLicenseDataAccess.GetDriverID(LicenseID);
        }



        public bool DeactivateLicense()
        {
            return clsLicenseDataAccess.DeactivateLicense(this.LicenseID);

        }

        public bool ReactivateLicense()
        {
            return clsLicenseDataAccess.ReactivateLicense(this.LicenseID);
        }




    }
}
