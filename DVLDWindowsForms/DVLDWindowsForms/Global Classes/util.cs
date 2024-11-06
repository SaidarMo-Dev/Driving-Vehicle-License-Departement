using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DVLD.Classes
{
    public class clsUtil
    {
        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();
            
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
         
            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
            
        }
     
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;

        }
       
        public static  bool CopyImageToProjectImagesFolder(ref string  sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolder = @"C:\visual projects\DVLDProject\DVLD-Images\";
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show (iox.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile= destinationFile;
            return true;
        }
        
        public static void SaveLoginInfoToAFile(string[] LoginInfo)
        {
            string Record = string.Join(";", LoginInfo);

            string FilePath = @"C:\visual projects\DVLDProject\DVLDWindowsForms\DVLDWindowsForms\LoginInformations.txt";

            File.WriteAllText(FilePath, Record);
            

        }

        public static void SaveLoginInfoToAFile()
        {
           

            string FilePath = @"C:\visual projects\DVLDProject\DVLDWindowsForms\DVLDWindowsForms\LoginInformations.txt";

            File.WriteAllText(FilePath, "");


        }

        public static string GetLoginInformationsFromFile()
        {
            string Path = @"C:\visual projects\DVLDProject\DVLDWindowsForms\DVLDWindowsForms\LoginInformations.txt";

            return File.ReadAllText(Path);
        }




        public static string Encrypt(string Plaintext, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(Plaintext);


                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }

            }
        }

        public static string Decrypt(string CipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform Decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(CipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, Decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();

                }


            }
        }

        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }



    }
}
