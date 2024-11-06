using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data;


namespace DVLDBusinessLayer
{
    public class Person
    {

        public enum enMode {AddNew =0 , Update =1}
        private enMode _Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }
     
        public DateTime DateOfBirth { set; get; }
        public int PersonAge
        {
            get { return _GetAge(); }
        }
        public byte Gendor { set; get; }
        public string GendorToString
        {
            get
            {
                return (this.Gendor == 0) ? "Male" : "Female";
            }
        }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        public Person ()
        {

            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gendor = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = 0;
            ImagePath = "";

            _Mode = enMode.AddNew;

        }

        private Person (int PersonID , string NationalNo, string FirstName ,string SecondName ,
                                    string ThirdName , string LastName, DateTime DateOfBirth, byte Gendor, 
                                    string Address, string Phone, string Email, int NationalityCountryID,
                                    string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            this._Mode = enMode.Update;

        }

        private int _GetAge()
        {
            int Age = (DateTime.Now.Year - this.DateOfBirth.Year);
            
            if (DateTime .Now < this .DateOfBirth .AddYears(Age))
            {
                return Age--;
            }

            return Age;

        }
       
        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName,
                                                                this.ThirdName, this.LastName, this.DateOfBirth,
                                                                this.Gendor, this.Address, this.Phone, this.Email,
                                                                this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson(this.PersonID ,this.NationalNo, this.FirstName, this.SecondName,
                                                    this.ThirdName, this.LastName, this.DateOfBirth,
                                                    this.Gendor, this.Address, this.Phone, this.Email,
                                                    this.NationalityCountryID, this.ImagePath);
            
        }

        public static Person FindByID(int ID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePatth = "";

            if (clsPeopleDataAccess.GetPersonByID(ID, ref NationalNo, ref FirstName, ref SecondName,
                                                   ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor,
                                                   ref Address, ref Phone, ref Email, ref NationalityCountryID,
                                                   ref ImagePatth))
            {
                return new Person(ID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                                                DateOfBirth, Gendor, Address, Phone, Email,
                                                NationalityCountryID, ImagePatth);
            }
            else
                return null;
        }

        public static Person FindByNationalNo(string NationalNo)
        {
            int PersonID = 0;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = 0;
            string ImagePatth = "";

            if (clsPeopleDataAccess.GetPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName,
                                                   ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor,
                                                   ref Address, ref Phone, ref Email, ref NationalityCountryID,
                                                   ref ImagePatth))
            {
                return new Person(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                                                DateOfBirth, Gendor, Address, Phone, Email,
                                                NationalityCountryID, ImagePatth);
            }
            else
                return null;
        }



        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;

                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();

                default:
                    return false;
            }
        }


        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleDataAccess.DeletePerson(PersonID);
        }


        public static DataTable GetPeople()
        {
            return clsPeopleDataAccess.GetPeople();
        }
    
        public static bool IsPersonExisteByID(int ID)
        {
            return clsPeopleDataAccess.IsPersonExisteByID(ID);
        }
        public static bool IsPersonExisteByNationalNo(string NationalNo)
        {
            return clsPeopleDataAccess.IsPersonExisteNationalNo(NationalNo);
        }
    
        public static string GetPersonImagePath(int PersonID)
        {
            return clsPeopleDataAccess.GetPersonImagePath(PersonID);
        }

     

        static void Main(string[] args)
        {
        }


    }
}
