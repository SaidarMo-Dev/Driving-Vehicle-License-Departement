using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class ApplicationType
    {
        public int ID { set; get; }
        public string ApplicationTypeTitle { set; get; }
        public double ApplicationFees { set; get; }


        public ApplicationType()
        {
            this.ID = -1;
            this.ApplicationTypeTitle = "";
            this.ApplicationFees = 0;

        }


        private ApplicationType(int ID , string AppTitle , double AppFees)
        {
            this.ID = ID;
            this.ApplicationTypeTitle = AppTitle;
            this.ApplicationFees = AppFees;

        }

      
        public static ApplicationType GetApplicationType(int ID)
        {
            string AppTitle = "";
            double AppFees = 0;

            if (clsApplicationTypeDataAccess.GetApplicationType(ID,ref AppTitle, ref AppFees))
            {
                return new ApplicationType(ID, AppTitle, AppFees);
         
            }

            return null;


        }

        public bool UpdateApplicationType()
        {
            return clsApplicationTypeDataAccess.UpdateApplicationTypes(this.ID ,this .ApplicationTypeTitle 
                           ,this .ApplicationFees);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeDataAccess.GetListApplicationTypes();
        }

    }



}
