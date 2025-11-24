using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Configuration;

namespace Arena_Whistle_Buisness_layer
{
    public static class ClsUtilB
    {
        public static string ComputeHash(string Password)
        {
            using(SHA256 SHA = SHA256.Create())
            {
                byte[] HashByte = SHA.ComputeHash(Encoding.UTF8.GetBytes(Password));

                return BitConverter.ToString(HashByte).Replace("-", "").ToLower();
            }
        }

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
            if(!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch(Exception ex)
                {
                    //MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo File_info = new FileInfo(fileName);
            string extn = File_info.Extension;
            return GenerateGUID() + extn;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile ,string DestinationFolder )
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.



            //string DestinationFolder = @"C:\Users\Admin\source\repos\Arena Whistle Project\Arena Whistle Photos";

            if(!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + @"\" + ReplaceFileNameWithGUID(sourceFile);

            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch(IOException iox)
            {
                //MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }

        //private static readonly string ReGistryPath = ConfigurationManager.AppSettings["RegistryPath"];



        public static bool RememberUsernameAndPassword(string ReGistryPath ,string username, string password)
        {

            try
            {
                // If username is empty, delete the registry keys
                if(string.IsNullOrEmpty(username))
                {
                    Registry.CurrentUser.DeleteSubKeyTree(ReGistryPath, false);
                    return true;
                }

                using(RegistryKey key = Registry.CurrentUser.CreateSubKey(ReGistryPath))
                {
                    key.SetValue("Username", username);
                    key.SetValue("Password", password); // optionally encrypt this
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public static (string Username, string Password)? GetSavedCredentials(string ReGistryPath)
        {

            try
            {
                using(RegistryKey key = Registry.CurrentUser.OpenSubKey(ReGistryPath))
                {
                    if(key == null)
                        return null;

                    string username = key.GetValue("Username") as string;
                    string password = key.GetValue("Password") as string;

                    return (username, password);
                }
            }
            catch
            {
                return null;
            }
        }



    }
}
