using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetEmployee()
        {
            Context obj = new Models.Context();
            return View(obj.GetEmployee());
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}