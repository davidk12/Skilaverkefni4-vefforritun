using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace skilaverkefni_4.Code
{
    public class Output_window_log_media : Log_media
    {
        public override void log_message(string message)
        {
            Debug.WriteLine(message + Environment.NewLine);
        }
    }
}