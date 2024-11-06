using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;

namespace DVLDBusinessLayer
{
    public class LocalDrivingLicenseApplication
    {
        private enum enMode { AddNew = 0, Update = 1}

        private enMode _Mode;

        public int LocalDrivingLicenseApplicationID {set;get;}
        public int ApplicationID { set; get; }
        public clsApplication ApplicationInfo { set; get; }
        public int LicenseClassID { set; get; }
        public LicenseClass LicenseClassInfo { set; get; }

        public LocalDrivingLicenseApplication()
        {
            _Mode = enMode.AddNew;

            this.LocalDrivingLicenseApplicationID  = -1;
            this.ApplicationID = -1;
            this.ApplicationInfo = null;
            this.LicenseClassID = -1;
            this.LicenseClassInfo = null;
            
        }

        private LocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this._Mode = enMode.Update;

            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID ;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.GetApplicationInfoByID(ApplicationID);
            this.LicenseClassID = LicenseClassID ;
            this.LicenseClassInfo = LicenseClass.GetLicenseClassInfoByID(LicenseClassID);

        }


        public static LocalDrivingLicenseApplication GetLocalDrivingLicenseApplication(int ID)
        {
            int ApplicationID = 0;
            int LicenseClassID = 0;

            if (clsLocalDrivingLicenseApplicationDataAccess.GetLocalDrivingLicenseApplicationInfo(ID ,ref ApplicationID, ref LicenseClassID))
            {
                return new LocalDrivingLicenseApplication(ID, ApplicationID, LicenseClassID);
            }

            return null;

        }

        private bool _AddNewLocalDrivingLicenseApplications()
        {
            if (this.ApplicationInfo.Save ())
            {
                this.ApplicationID = this.ApplicationInfo.ApplicationID;

                this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationDataAccess.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

                return (this.LocalDrivingLicenseApplicationID != -1);
            }

            return false;

        }


        private bool _UpdateLocalDrivingLicenseApplications()
        {
            
            return ((this .ApplicationInfo.Save ()) && (clsLocalDrivingLicenseApplicationDataAccess.UpdateLocalDrivingLicenseApplication(this .LocalDrivingLicenseApplicationID ,this .LicenseClassID)));
          
   
        }

        public bool Delete()
        {

            if (clsLocalDrivingLicenseApplicationDataAccess.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID))
            {
                return clsApplication.DeleteApplication(this.ApplicationID);
            }

            return false;

        }

        public static DataTable GetListLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetListLocalDrivingLicenseApplications();

        }

        public static bool IsLocalDrivingLicenseApplicationExisteByID(int LocalApplicationID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.IsLocalDrivingLicenseApplicationExisteByID(LocalApplicationID);
        }

        public static bool IsPersonHasAnotherLocalApplicationWithSameLicenseClass(int PersonID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.IsPersonHasAnotherLocalApplicationWithSameLicenseClass(PersonID , LicenseClassID);

        }

        public bool Save()
        {
            if (_Mode == enMode.AddNew)
            {
                if (_AddNewLocalDrivingLicenseApplications())
                {
                    _Mode = enMode.Update;
                    return true;

                }

                return false;

            }

            return _UpdateLocalDrivingLicenseApplications();

        }
        
      
        public static byte PassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTestDataAccess.PassedTests(LocalDrivingLicenseApplicationID);
        }

        public static byte TotalTrilesPerTest(int LocalDrivingLiceneApplicationID, int TestTypeID ) 
        {
            return clsLocalDrivingLicenseApplicationDataAccess.TotalTrilesPerTest(LocalDrivingLiceneApplicationID, TestTypeID);
        }

        public bool DoesAttendTest(int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.DoesAttendTest(this.LocalDrivingLicenseApplicationID, TestTypeID);
        }
    
        public static bool DoesHaveUnlockedTest(int LocalDrivingLicenseapplicationID, int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.DoesHaveUnlockedTest(LocalDrivingLicenseapplicationID, TestTypeID);
        }
    
        public static bool DoesPassedTheTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationDataAccess.DoesPassedTheTest(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        public bool IsLicenseIssued()
        {
            return clsLicense.IsLicenseExisteByApplicationID(this.ApplicationID);
        }
    
        public int GetActiveLicenseID()
        {
            return clsLicenseDataAccess.GetActiveLicenseID(this.ApplicationID);

        }

        public int IssueLicenseForTheFirstTime(string Notes, int CreatedByUserID)
        {
        
            Driver Driver = new Driver();


            // first, we check whether the person to whom the clsLicense to be issued is a driver or not 

            // if the person is not a driver we add them as a driver 

            if (!Driver.IsPersonAlreadyDriver(this .ApplicationInfo .ApplicationPersonID))
            {
                Driver.PersonID = this.ApplicationInfo.ApplicationPersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                Driver.CreatedDate = DateTime.Now;

                if (!Driver.Save())
                {
                  
                    return -1;
                }

            }
            else
            {
                // if the person is a driver we get his informations

                Driver = Driver.GetDriverInfoByPesonID(this.ApplicationInfo.ApplicationPersonID);

            }


            // here we start to create the license informations 

            clsLicense LicenseToIssueForTheDriver = new clsLicense();

            LicenseToIssueForTheDriver.ApplicationID = this.ApplicationInfo.ApplicationID;
            LicenseToIssueForTheDriver.DriverID = Driver.DriverID;
            LicenseToIssueForTheDriver.LicenseClassID = this.LicenseClassID;
            LicenseToIssueForTheDriver.IssueDate = DateTime.Now;
            LicenseToIssueForTheDriver.ExpirationDate = (DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength));
            LicenseToIssueForTheDriver.Notes = Notes;
            LicenseToIssueForTheDriver.PaidFees = this.LicenseClassInfo.LicenseClassFess;
            LicenseToIssueForTheDriver.IsActive = true;
            LicenseToIssueForTheDriver.IssueReason = clsLicense.enIssueReason.FirstTime;
            LicenseToIssueForTheDriver.CreatedBuyUserID = CreatedByUserID;



             
            if (!LicenseToIssueForTheDriver.Save())
            {
                return -1;
            }

            SetComplete();

            return LicenseToIssueForTheDriver.LicenseID;

              
        }


        public bool Cancel()
        {
            return clsApplicationsDataAccess.UpdateApplicationStatus(this.ApplicationID, 2);
        }

        public bool SetComplete()
        {
            return clsApplicationsDataAccess.UpdateApplicationStatus(this.ApplicationID, 3);
        }

    }
}
