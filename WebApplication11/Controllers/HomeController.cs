using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public JsonResult EmpDetails()
        {
            //Creating List    
            List<Employee> ObjEmp = new List<Employee>()
        {    
            //Adding records to list    
            new Employee {Id=1,Name="Vithal Wadje",City="Latur",Address="Kabansangvi" },
            new Employee {Id=2,Name="Sudhir Wadje",City="Mumbai",Address="Kurla" }
            };
            //return list as Json    
            return Json(ObjEmp, JsonRequestBehavior.AllowGet);
        }
    }
}
