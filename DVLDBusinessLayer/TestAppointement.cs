using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;


namespace DVLDBusinessLayer
{
    public class TestAppointement
    {

        enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode ;
        public int TestAppointementID { set; get; }
        public int TestTypeID { set; get; }
        public clsTestType TestTypeInfo { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public LocalDrivingLicenseApplication LocalDrivingLicenseApplicationInfo { set; get; }
        public DateTime AppointementDate { set; get; }
        public double PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public User CreatedUserInfo { set; get; }
        public bool IsLocked { set; get; }
        public int RetakeTestApplicationID { set; get; }
        public clsApplication RetakeTestApplicationInfo { set; get; }
        public TestAppointement()
        {
            this._Mode = enMode.AddNew;

            this.TestAppointementID = -1;
            this.TestTypeID = -1;
            this.TestTypeInfo = new clsTestType();
            this.LocalDrivingLicenseApplicationID = -1;
            this.LocalDrivingLicenseApplicationInfo = new LocalDrivingLicenseApplication();
            this.AppointementDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.CreatedUserInfo = new User();
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            this.RetakeTestApplicationInfo = new clsApplication();

        }

        private TestAppointement(int TestAppointementID, int TestTypeID, int LocalApplicationID,
                                  DateTime AppointementDate, double Fees, int CreatedByUserID,
                                    bool IsLocked, int RetakeTestApplicationID)
        {

            this._Mode = enMode.Update;

            this.TestAppointementID = TestAppointementID;
            this.TestTypeID = TestTypeID;
            this.TestTypeInfo = clsTestType.GetTestType(TestTypeID);
            this.LocalDrivingLicenseApplicationID = LocalApplicationID;
            this.LocalDrivingLicenseApplicationInfo = LocalDrivingLicenseApplication .GetLocalDrivingLicenseApplication(LocalApplicationID);
            this.AppointementDate = AppointementDate;
            this.PaidFees = Fees ;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedUserInfo = User .GetUserByID(CreatedByUserID);
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeTestApplicationInfo = clsApplication.GetApplicationInfoByID(RetakeTestApplicationID);



        }
       

        public static TestAppointement GetTestAppointementByID(int TestAppointementID)
        {
            int TestTypeID = -1;
            int LocalApplicationID = -1;
            DateTime AppointementDate = DateTime.Now;
            double PaidFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID= -1;

            if (TestAppointementDataAccess.GetTestAppointementInfo(TestAppointementID,ref TestTypeID ,ref LocalApplicationID,
                                                                     ref AppointementDate ,ref PaidFees ,ref CreatedByUserID, 
                                                                     ref IsLocked,ref RetakeTestApplicationID ))
            {
                return new TestAppointement(TestAppointementID, TestTypeID, LocalApplicationID,
                                             AppointementDate, PaidFees, CreatedByUserID,
                                             IsLocked, RetakeTestApplicationID);
            }

            return null;

        }

        public bool _AddNewTestAppointement()
        {
            this.TestAppointementID = TestAppointementDataAccess.AddNewTestAppointement(this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                                                                                       this.AppointementDate, this.PaidFees, this.CreatedByUserID,
                                                                                       this.IsLocked, this.RetakeTestApplicationID);

            return (this.TestAppointementID != -1);

        }

        public bool _UpdateTestAppointement()
        {
            return TestAppointementDataAccess.UpdateTestAppointement(this.TestAppointementID, this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                                                                      this.AppointementDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew :
                    if (_AddNewTestAppointement())
                    {
                        this._Mode = enMode.Update;
                        return true;

                    }
                    return false;

                case enMode.Update :
                    return _UpdateTestAppointement();

                default :
                    return false;

            }
        }

        public static DataTable GetAllTestAppointements(int LocalApplicationID, int TestTypeID)
        {
            return TestAppointementDataAccess.GetAllTestAppointementsWithinTheTestType(LocalApplicationID, TestTypeID);
        }


    }
}
