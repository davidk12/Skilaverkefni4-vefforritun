using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace skilaverkefni_4.Code
{
    public class Logger                                                               
    {
        private static List<Log_media> mediaList;                                              // The logger is a singleton class
                                                                                               // meaning there will only be created one
        private static Logger theInstance = null;                                              // instance of the logger and this instance
                                                                                               // will be used until the program is terminated.
        public static Logger Instance
        {
            get
            {
                if (theInstance == null)
                {
                    theInstance = new Logger();
                    mediaList = new List<Log_media>();
                    Text_file_log_media file_log = new Text_file_log_media();                   // Create instances of for the text_file,
                    Output_window_log_media window_log = new Output_window_log_media();         // output, and email logging.
                    Email_log_media email_log = new Email_log_media();                          // Add these objects to the mediaList list.

                    mediaList.Add(file_log);
                    mediaList.Add(window_log);
                    mediaList.Add(email_log);
                }
                return theInstance;
            }
        }

        public void logException(Exception ex)                                                  // Loop through each object of Log_media in the mediaList list
        {                                                                                       // And log the exception.
            string E = DateTime.Now + ": " + ex.Message + " Type: " + ex.GetType();

            foreach(Log_media r in mediaList)
            {
                r.log_message(E);
            }
        }
    }
}