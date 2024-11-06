using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;
using System.Data ;

namespace DVLDBusinessLayer
{
    public class User
    {
        enum enMode { AddNew= 0, Update =1}

        private enMode _Mode;

        public int UserID { set; get; }
        public int PersonID {set;get;}
        public Person PersonInfo { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }


        public User ()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password ="";
            IsActive = false;

            _Mode = enMode.AddNew;

        }

        private User (int UserID , int PersonID, string UserName,string Password , bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = Person.FindByID(PersonID);
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            _Mode = enMode.Update;
        }


        public static User GetUserByID(int ID)
        {
            int PersonId = -1;
            string Username = "";
            string Password = "";
            bool IsActive = false;

            if (clsUserDataAccess.GetUserByID(ID, ref PersonId, ref Username, ref Password, ref IsActive))
            {
                return new User(ID, PersonId, Username, Password, IsActive);
            }

            return null;

        }

        public static User GetUserByUsername(string Username)
        {
            int UserID = -1;
            int PersonId = -1;
            string Password = "";
            bool IsActive = false;

            if (clsUserDataAccess.GetUserByUsername(Username,ref UserID, ref PersonId, ref Password, ref IsActive))
            {
                return new User(UserID, PersonId, Username, Password, IsActive);
            }

            return null;

        }
       
        public static User GetUserInfoByUsernameAndPassword(string Username, string Password)
        {
            int UserID = -1;
            int PersonId = -1;
            bool IsActive = false;

            bool IsFound =  clsUserDataAccess.GetUserByUsernameAndPassword(
                Username, Password, ref UserID, ref PersonId, ref IsActive);
            
            
            if (IsFound)
            {
                return new User(UserID, PersonId, Username, Password, IsActive);
            }

            return null;

        }
     
        private bool _AddNewUser ()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive);

            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);

        }

     
        public bool Save()
        {
            switch (_Mode )
            {
                case enMode.AddNew :
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update :
                    return _UpdateUser();

                default :
                    return false;
            }

        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }
       
       
      
       
        public static bool IsUserExisteByID(int ID)
        {
            return clsUserDataAccess.IsUserExisteByID(ID);
        }
        public static bool IsUserExisteByUsername(string Username)
        {
            return clsUserDataAccess.IsUserExisteByUsername(Username);
        }
        
        
        public static bool DeleteUser(int ID)
        {
            return clsUserDataAccess.DeleteUser(ID);
        }

    
        public static bool IsPersonhaveUser(int PersonID)
        {
            return clsUserDataAccess.IsPersonHaveUser(PersonID);
        }
    }

}
