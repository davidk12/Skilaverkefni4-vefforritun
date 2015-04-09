using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Configuration;

namespace skilaverkefni_4.Code
{
    public class Text_file_log_media : Log_media
    {
        private string file = ConfigurationManager.AppSettings["LogFile"];    // Grab the path name from the Web.config file.

        public override void log_message(string message)
        {
            File.AppendAllText(file, message + Environment.NewLine);
        }
    }
}