using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassDeclarationsThsesis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rules()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Declare()
        {
            ViewBag.Message = "Declare a homework.";

            return View();
        }

        public ActionResult SetHomework()
        {
            ViewBag.Message = "Set a homework.";

            return View();
        }

        public ActionResult MyMarks()
        {
            ViewBag.Message = "See your marks.";

            return View();
        }
    }
}