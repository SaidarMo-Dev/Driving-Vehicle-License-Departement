using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;


namespace DVLDBusinessLayer
{
    public class InternatinalLicense
    {
        public int InternationalLiceneID { set; get; }
        public int ApplicationID { set; get; }
        public clsApplication ApplicationInfo { set; get; }
        public int DriverID { set; get; }
        public Driver DriverInfo { set; get; } 
        public int IssuedUsingLocalLicenseID { set; get; }
        public clsLicense IssuedUsingLocalLicenseInfo { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }
        public int CreatedByUserID { set; get; }
        public User CreatedByUserInfo { set; get; }



        public InternatinalLicense()
        {
           this.InternationalLiceneID = -1;
           this.ApplicationID = -1;
           this.ApplicationInfo = new clsApplication();
           this.DriverID = -1;
           this.DriverInfo = new Driver ();
           this.IssuedUsingLocalLicenseID = -1;
           this.IssuedUsingLocalLicenseInfo = new clsLicense ();
           this.IssueDate = DateTime .Now ;
           this.ExpirationDate = DateTime .Now ;
           this.IsActive = false;
           this.CreatedByUserID = -1;
           this.CreatedByUserInfo = new User();


        }


        private InternatinalLicense (int InternationalLicenseID,int ApplicationID,int DriverID,
                            int IssuedUsingLocalLicenseID, DateTime IssueDate,
                            DateTime ExpirationDate, bool IsActive,int CreatedByUserID)
        {


            this.InternationalLiceneID = InternationalLiceneID;
            this.ApplicationID = ApplicationID ;
            this.ApplicationInfo = clsApplication.GetApplicationInfoByID(ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = Driver.GetDriverInfo(DriverID);
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssuedUsingLocalLicenseInfo = clsLicense.GetLicenseInfoBylicenseID(IssuedUsingLocalLicenseID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = User.GetUserByID(CreatedByUserID);


        }




        public static InternatinalLicense GetInternationalLicenseInfo(int InternationalLicenseID)
        {
          
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsInternationalLicenseDataAccess.GetInternationalLicenseInfoByID(InternationalLicenseID,
                            ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate,
                            ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new InternatinalLicense(InternationalLicenseID, ApplicationID, DriverID,
                                                IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                                                IsActive, CreatedByUserID);
            }
            else
                return null;

        }
    
        private bool _AddNewInternationalLicense()
        {
            this.InternationalLiceneID = clsInternationalLicenseDataAccess.AddNewInternationalLicense
                                          (this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                                          this.IssueDate, this.ExpirationDate, this.IsActive,
                                          this.CreatedByUserID);

            return (this.InternationalLiceneID != -1);
        
        
        }
    

        public static DataTable GetListInternationalLicenses()
        {
            return clsInternationalLicenseDataAccess.GetListInternationalLicenses();

        }
    
        public static DataTable GetPersonInternationalLicenses(int PersonID)
        {
            return clsInternationalLicenseDataAccess.GetDriverLicenses
                               (Driver.GetDriverInfoByPesonID(PersonID).DriverID);
        }
    

        public bool Save()
        {
            return this._AddNewInternationalLicense();

        }

        public static bool IsDriverHaveActiveInternationalLicense(int DriverID)
        {
            return clsInternationalLicenseDataAccess.IsDriverHaveActiveLicense(DriverID);
        }


        public static DataTable LoadPersonInternationalLicenses(int PersonID)
        {

            return clsInternationalLicenseDataAccess.LoadDriverInternationalLicenses(Driver.GetDriverInfoByPesonID(PersonID).DriverID);
        }
    }
}
