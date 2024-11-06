using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data ;
namespace DVLDBusinessLayer
{
    public class Driver
    {

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public Person PersonInfo { get; set; }
        public int CreatedByUserID { get; set; }
        public User CreatedByUserInfo { get; set; }
        public  DateTime CreatedDate { get; set; }

        public Driver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.PersonInfo = new Person();
            this.CreatedByUserID = -1;
            this.CreatedByUserInfo = new User();
            this.CreatedDate = DateTime.Now;



        }
        private Driver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.PersonInfo = Person .FindByID (PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = User .GetUserByID (CreatedByUserID);
            this.CreatedDate = CreatedDate;


        }


        public static Driver GetDriverInfo(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverDataAccess.GetDriverInfoByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new Driver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }


            return null;
        }
     
        public static Driver GetDriverInfoByPesonID(int PersonID)
        {
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriverDataAccess.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                return new Driver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }


            return null;
        }


        private bool _AddNewDriver()
        {
            this .DriverID = clsDriverDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return (this.DriverID != -1);
        
        
        }

        public static DataTable GetListDrivers()
        {
            return clsDriverDataAccess.GetAllDrivers();
        }


        public bool Save()
        {
            return _AddNewDriver();
        }
        public static bool IsPersonAlreadyDriver(int PersonID)
        {
            return clsDriverDataAccess.IsPersonAlreadyDriver(PersonID);
        }

    }
}
