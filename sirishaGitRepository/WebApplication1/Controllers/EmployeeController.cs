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
        Context obj = new Context();

        public ActionResult GetEmployee()
        {
            return View(obj.GetEmployee());
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee empobj)
        {
            int i=obj.SaveEmployee(empobj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(empobj);
            }
        }
    }
}