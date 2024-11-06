using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTest
    {
        enum enMode { AddNew = 1, Update = 2 };
        private enMode _Mode;

        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public TestAppointement TestAppointmentInfo { set; get; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }
        public User CreatedByUserIfo { set; get; }

        public clsTest()
        {
            this._Mode = enMode.AddNew;

            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestAppointmentInfo = new TestAppointement();
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
            this.CreatedByUserIfo = new User();


        }

        private clsTest (int TestID, int TestAppointementID, bool TestResult, string Notes, int CreatedByUserID )
        {
            this._Mode = enMode.Update;

            this.TestID = TestID ;
            this.TestAppointmentID = TestAppointementID;
            this.TestAppointmentInfo = TestAppointement.GetTestAppointementByID(TestAppointementID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserIfo = User.GetUserByID(CreatedByUserID);

        }


        public static clsTest GetTestInfoByID(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = "";
            int CreatedByUserID = -1;

            if (clsTestDataAccess .GetTestInfoByID(TestID ,ref TestAppointmentID ,ref TestResult ,ref Notes ,ref CreatedByUserID))
            {
                return new clsTest(TestID ,TestAppointmentID ,TestResult ,Notes ,CreatedByUserID);
            }

           return null;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult, 
                                                        this.Notes, this.CreatedByUserID);
            return (this.TestID != -1);

        }

        private bool _UpdateTest()
        {
            return clsTestDataAccess.UpdateTest(this.TestID, this.TestAppointmentID,
                                        this.TestResult, this.Notes, this.CreatedByUserID);

        }


        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew :
                    if (_AddNewTest ())
                    {
                        this._Mode = enMode.Update;
                        return true;

                    }
                    return false;

                case enMode.Update :
                    return _UpdateTest();

                default :
                    return false;
            }
        }
    
    
    
    }
}
