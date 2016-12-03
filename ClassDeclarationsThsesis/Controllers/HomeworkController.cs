using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ClassDeclarationsThsesis.Classes;
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
        

        /*private DropDownList GetSubjects(string[] selectedValues)
        {

            List<Subject> Subjects = new List<Subject>()

        {

            new Subject() { subject_id = 1, name = "Numerical Methods", headteacher_id = 1, teachers = new List<User>() { new User() {name = "John", surname = "Doe", user_id = 2, user_type = 2, email = "john@mail.com", password = "dsds" }}, students = new List<User>() { new User() {name = "Jane", surname = "Doe", user_id = 3, user_type = 1, email = "jane@mail.com", password = "dsds" }}},

            new Subject() { subject_id = 2, name = "Numerical Methods", headteacher_id = 1, teachers = new List<User>() { new User() {name = "John", surname = "Doe", user_id = 2, user_type = 2, email = "john@mail.com", password = "dsds" }}, students = new List<User>() { new User() {name = "Jane", surname = "Doe", user_id = 3, user_type = 1, email = "jane@mail.com", password = "dsds" }}},

            
        };
            DropDownList s = new DropDownList();
            s.Items.Insert(0,Subjects.ElementAt(0).name);
            s.Items.Insert(1, Subjects.ElementAt(1).name);

            return s;

        }

        public ActionResult MultiSelectSubject()
        {

            ViewBag.Subjectslist = GetSubjects(null);

            return View();

        }*/
    }
}