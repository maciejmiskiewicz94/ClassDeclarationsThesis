using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassDeclarationsThsesis.Models;

namespace ClassDeclarationsThsesis.Controllers
{
    public class DeclareController : Controller
    {
        // GET: Declare
        public ActionResult Index()
        {
            ClassDeclarationsDBEntities1 entities=new ClassDeclarationsDBEntities1();
            return View(entities.Tasks.ToList());
        }
    }
}