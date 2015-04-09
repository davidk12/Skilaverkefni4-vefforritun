using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using skilaverkefni_4.Models;
using skilaverkefni_4.Code;

namespace skilaverkefni_4.Controllers
{
    public class HomeController : Controller
    {
        public Random rand = new Random(); 
        public ActionResult Index()
        {
            int num = rand.Next(1, 6);                                  
            try
            {
                if (num == 5)                                                           // 1/5th chance that an exception is thrown.
                {
                    throw new ArgumentException();
                }
            }

            catch (ArgumentException ex)
            {
                Logger.Instance.logException(ex);                                       // Log the exception and return the view and
                return View("Exception_view", ex);                                      // Exception instance.
            }                                                                           

            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }

        public ActionResult link1()
        {
            return RedirectToAction("Index");
        }

        public ActionResult link2()
        {
            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            int num = rand.Next(1, 6);
            try
            {
                if (num == 5)
                {
                    throw new MyApplicationException("You managed to break something. Nicely done.");
                }
            }
            catch (MyApplicationException ex)
            {
                Logger.Instance.logException(ex);
                return View("Exception_view", ex);
            } 
            return View();
        }
    }
}
