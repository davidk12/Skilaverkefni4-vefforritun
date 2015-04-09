using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace skilaverkefni_4.Code
{
    public class MyApplicationException : Exception
    {
        public MyApplicationException(String message) : base(message) { }
    }
}