using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            int a = 2;
            if (a == 1)
            {
                return Redirect("http://www.google.com");
            }
            else
            {
                ViewBag.data = "Bakery is Open Today";
              return View();
            }
        }

        public RedirectToRouteResult contact() {
           return RedirectToAction("GetEmployee", "Employee");
        }

        public RedirectToRouteResult GetMethodByRoute()
        {
            return RedirectToRoute("Default1");
        }

        public JsonResult GetEmpData()
        {
            List<Employee> listobj = new List<Employee>();
            Employee obj = new Models.Employee();
            obj.EmpId = 1;
            obj.EmpName = "Rajeeval";
            obj.EmpSalary = 250000;

            Employee obj1 = new Models.Employee();
            obj1.EmpId = 2;
            obj1.EmpName = "Manav";
            obj1.EmpSalary = 450000;

            listobj.Add(obj);
            listobj.Add(obj1);

            return Json(listobj,JsonRequestBehavior.AllowGet);
        }

        public FileResult GetFile()
        {
            return File("~/Web.config", "application/xml", "Web.config");
        }

        public ContentResult GetContent(int id)
        {
            if (id == 1)
            {
                return Content("hello");
            }
            else if (id==2)
            {
                return Content("<p style=color:red>hello</p>");
            }
            else
            {
                return Content("<script>alert('hello world')</script>");
            }
        }
    }
}