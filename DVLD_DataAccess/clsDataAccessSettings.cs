using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;


namespace DVLD_DataAccess
{
    public class clsDataAccessSettings
    {
       // public static string con =ConfigurationManager.ConnectionStrings["MyDbConnectionString"].ConnectionString.ToString();
        public static string ConnectionString = "Server=.; Database=DLVD_First; user Id=sa; Password =sa123456; ";

        public static void SaveToEventLog(string EventMessage, EventLogEntryType eventLogEntryType, string SourceApp = "DVLD_App")
        {

            try
            {
                if (!EventLog.SourceExists(SourceApp))
                    EventLog.CreateEventSource(SourceApp, "Application");

                EventLog.WriteEntry(SourceApp, EventMessage, eventLogEntryType);
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(SourceApp, "Exception in LogException method", EventLogEntryType.Error);
            }

        }
    
    }
}
