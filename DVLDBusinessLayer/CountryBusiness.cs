using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVLDDataAccessLayer;
using System.Data ;

namespace DVLDBusinessLayer
{
    public class clsCountry
    {

        public int ID { set; get;}
        public string CountryName { set; get; }

        public clsCountry()
        {
            this.ID = -1;
            this.CountryName = "";

        }

        private clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
     
          
        }

      
        public static clsCountry FindCountryByID(int ID)
        {
            string CountryName = "";
           

            if (clsCountryDataAccess.GetCountryInfoByID(ID, ref CountryName)) 
            {
                return new clsCountry(ID, CountryName);
            }
            else
            {
                return null;
            }
        }


        public static clsCountry  FindCountryByName(string Name)
        {
            int CountryID = -1;
            string Code = "";
            string PhoneCode = "";

            if (clsCountryDataAccess.GetCountryInfoByName(Name, ref CountryID))
            {
                return new clsCountry(CountryID, Name);
            }
            else 
                return null;

        }

    
        public static DataTable GetListCountries()
        {
            return clsCountryDataAccess.GetListCountries();
        
        }



    }




}
