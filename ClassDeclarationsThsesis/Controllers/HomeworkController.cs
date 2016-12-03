using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassDeclarationsThsesis.Models;
using ClassDeclarationsThsesis.Models;

namespace ClassDeclarationsThsesis.Controllers
{
    public class HomeworkController : Controller
    {
        // GET: Homework/Random
        public ActionResult Random()
        {
            var homework=new Homework() {name = "Homework1", deadline = DateTime.Today, subject_id = 1};

            return View();
        }

        public ActionResult SetHomework()
        {
            return View();
        }

        public ActionResult Declare()
        {
            return View();
        }
    }
}