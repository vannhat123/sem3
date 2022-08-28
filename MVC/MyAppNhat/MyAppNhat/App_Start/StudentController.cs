using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAppNhat.App_Start
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["name"] = "Nguyen van nhat";
            TempData["age"] = "28";
            TempData["address"] = "Ha Noi";
            return View("ShowData");
        }

        public ActionResult ShowData()
        {
            return View();
        }

   
    }
}