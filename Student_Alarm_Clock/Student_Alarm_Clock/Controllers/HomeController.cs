using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Alarm_Clock.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AlarmList()
        {
            ViewBag.Message = "Alarm List Page";

            return View();
        }
        
        public ActionResult AlarmLog()
        {
            ViewBag.Message = "Alarm Log Page";

            return View();
        }
    }
}