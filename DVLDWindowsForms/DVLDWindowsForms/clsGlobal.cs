using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDBusinessLayer;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Cryptography;




namespace DVLDWindowsForms
{
    public class clsGlobal
    {

        public static User CurrentUserInfo { set; get; }



        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {

                string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\CREDENTIAL";

                string ValueName = "LoginInfo";


               
                // if username is empty we delete The record in windows registry 

                if (Username == "")
                {

                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(KeyPath, true))
                    {
                        
                            if (key != null)
                            {
                                key.DeleteValue(ValueName);
                            }
                        
                    }

                    return true;
                }

                // record to save 
                string RecordToSave = Username + "/#/" + Password;

                Registry.SetValue(KeyPath, ValueName, RecordToSave,RegistryValueKind.String);



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

                return false;

            }

            return true;


        }



        //public static bool RememberUsernameAndPassword(string Username,string Password)
        //{

        //    try
        //    {

        //        // get current Project directory 
        //        string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                
        //        // define the file path to save the Login informations

        //        string FilePath = CurrentDirectory + "\\LoginInfo.txt";

        //        // if username is empty we delete the txt file 
        //        if (Username == "" && File.Exists(FilePath))
        //        {
        //            File.Delete(FilePath);
        //            return true;
        //        }

        //        // record to save 
        //        string RecordToSave = Username + "/#/" + Password;

        //        // we create a strem reader 
        //        using (StreamWriter writer = new StreamWriter(FilePath))
        //        {
        //            //  Write the data to the file
        //            writer.WriteLine(RecordToSave);

        //            return true;
        //        }


        //    }
        //    catch(Exception ex)

        //    {
        //        MessageBox.Show ("An error occurred: "+ ex.Message);

        //        return false;

        //    }
            



        //}



        public static bool GetStoredCredential(ref string Username, ref string Password)
        {

            try
            {
               
                string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\CREDENTIAL";

                string ValueName = "LoginInfo";

                string UserInfo = Registry.GetValue(KeyPath, ValueName, null) as string;

                if (UserInfo == null)
                    return false;


                string[] LoginInfo = UserInfo.Split(new string[] { "/#/" }, StringSplitOptions.None);

                Username = LoginInfo[0];
                Password = LoginInfo[1];

                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

                return false;
            }


        }
        


        //public static bool GetStoredCredential(ref string Username, ref string Password)
        //{

        //    try
        //    {
        //        // get current project directory
        //        string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

        //        // define the file path 
        //        string FilePath = CurrentDirectory + "\\LoginInfo.txt";

        //        if (File .Exists(FilePath))
        //        {
        //            using (StreamReader reader = new StreamReader(FilePath))
        //            {

        //                string Line;

        //                while ((Line = reader.ReadLine()) != null)
        //                {

        //                    string[] LoginInfo = Line.Split(new string[] { "/#/" }, StringSplitOptions.None);

        //                    Username = LoginInfo[0];
        //                    Password = LoginInfo[1];

        //                    return true;

        //                }

        //                return false;


        //            }

        //        }
        //        else
        //        {
        //            return false;
        //        }
               

        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Error : " + ex.Message);

        //        return false;
        //    }


        //}


    

    }
}
