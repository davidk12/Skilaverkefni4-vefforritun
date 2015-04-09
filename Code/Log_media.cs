using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace skilaverkefni_4.Code
{
    public abstract class Log_media                                     // Abstract class, means there is never created an instance
    {                                                                   // of this class, just his child classes.
        public abstract void log_message(string message);
    }
}