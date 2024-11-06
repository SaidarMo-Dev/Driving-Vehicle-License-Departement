using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data ;

namespace DVLDBusinessLayer
{
    public class clsApplication
    {
        private enum enMode { AddNew = 0, Update = 1}
        public enum enApplicationTypes { NewLocalDrivingLicenseService = 1, RenewDrivingLicenseService = 2, ReplacementForLostDrivingLicense = 3, ReplacementForDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7 };
        private enMode _Mode;

        public enum enApplicationStatus { New = 1, Canceled = 2, Completed = 3 };

        public int ApplicationID { set; get; }
        public int ApplicationPersonID { set; get; }
        public Person PersonInfo { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public ApplicationType ApplicationTypeInfo { set; get; }
        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusWord
        {
            get
            {
               switch (this.ApplicationStatus)
               {
                   case enApplicationStatus .New :
                       return "New";
                   case enApplicationStatus.Canceled:
                       return "Canceled";
                   case enApplicationStatus.Completed :
                       return "Completed";          
                      
                   default :
                       return "";
               }
            }
        }

        public DateTime LastStatusDate { set; get; }
        public double PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public User CreaterUserInfo { set; get; }


        public clsApplication()
        {
            _Mode = enMode.AddNew;

            ApplicationID = -1;
            ApplicationPersonID = -1;
            PersonInfo = null;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationTypeInfo = null;
            ApplicationStatus = enApplicationStatus .New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = -1;
            CreaterUserInfo = null;



        }

        private clsApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate,
                            int ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
                            double PaidFees, int CreatedByUserID )
        {
            _Mode = enMode.Update;

            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.PersonInfo = Person.FindByID(ApplicationPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = ApplicationType.GetApplicationType(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreaterUserInfo = User.GetUserByID(CreatedByUserID);


        }


        public static clsApplication GetApplicationInfoByID(int ApplicationID)
        {
            int AppPersonID = -1;
            DateTime AppDate = DateTime.Now;
            int AppTypeID = -1;
            byte AppStatus = 1;
            DateTime LastStatusDate = DateTime.Now;
            double AppPaidFees = 0;
            int CreatedByUserID = -1;

            if (clsApplicationsDataAccess.GetApplicationInfoByID(ApplicationID,ref AppPersonID, ref AppDate,  ref AppTypeID, ref AppStatus, 
                                                                    ref LastStatusDate, ref AppPaidFees, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, AppPersonID, AppDate, AppTypeID, (enApplicationStatus) AppStatus, 
                                            LastStatusDate, AppPaidFees, CreatedByUserID);

            }

            return null;


        }


        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationsDataAccess.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID,
                                                                            (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);

        }
        private bool  _UpdateApplication()
        {
            return clsApplicationsDataAccess.UpdateApplication(this.ApplicationID, this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID,
                                                                  (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }

        public static bool CancelApplication(int AppID, byte AppStatus)
        {
            return clsApplicationsDataAccess.UpdateApplicationStatus(AppID, AppStatus);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationsDataAccess.DeleteApplication(ApplicationID);
        }




        public static DataTable GetAllApplication()
        {
            return clsApplicationsDataAccess.GetAllApplications();

        }




        public bool Save()
        {
            if (_Mode == enMode.AddNew)
            {
                if (_AddNewApplication())
                {
                    _Mode = enMode.Update;

                    return true;

                }

                return false;

            }
            else
                return _UpdateApplication();
           

        }
        
        public static bool UpdateApplicationStatus(int ApplicationID, clsApplication .enApplicationStatus ApplicationStatus)
        {
            return clsApplicationsDataAccess.UpdateApplicationStatus(ApplicationID, (byte)ApplicationStatus);
        }

    }
}
