﻿using System;
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