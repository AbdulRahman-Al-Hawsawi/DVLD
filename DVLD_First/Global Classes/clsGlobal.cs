using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVLD_Business;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace DVLD_First.Global_Classes
{
    class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\LogedInUserInfo";
            string ValueName = "UserNameAndPassword";

            try
            {
                if (Username == "")
                {
                    string keyPathToDelete = @"SOFTWARE\LogedInUserInfo";
                    /// delete data from registry
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(keyPathToDelete, true))
                        {
                            if (key != null)
                            {
                                key.DeleteValue(ValueName);
                                return true;
                            }
                        }
                    }
                }
                    
                string DataToSave = Username + "#//#" + Password;
                Registry.SetValue(keyPath, ValueName, clsDataHelper.Encrypt(DataToSave), RegistryValueKind.String);
                return true;

            }
            catch(Exception e)
            {
                //MessageBox.Show("An error occured {0}", e.Message);
                return false;

            }


        }

        public static bool GetStoredCredintial(ref string Username, ref string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\LogedInUserInfo";
            string ValueName = "UserNameAndPassword";

            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                
                string LoginInfo = Registry.GetValue(keyPath, ValueName, null) as string;

                string[] Line = clsDataHelper.Decrypt(LoginInfo).Split(new string[] { "#//#" }, StringSplitOptions.None);

                if (Line[0] == "")
                    return false;

                    Username = Line[0];
                    Password = Line[1];
                    return true;

            }
            catch (Exception e)
            {
                //MessageBox.Show("An error occured {0}", e.Message);
                return false;
            }
        }

        


        public static void SaveToEventLog(string EventMessage, EventLogEntryType eventLogEntryType, string SourceApp = "DVLD_App")
        {

            try
            {
                if(!EventLog.SourceExists(SourceApp))
                EventLog.CreateEventSource(SourceApp,"Application");

                EventLog.WriteEntry(SourceApp,EventMessage,eventLogEntryType);
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(SourceApp,"Exception in LogException method",EventLogEntryType.Error);
            }

        }
    }
}
