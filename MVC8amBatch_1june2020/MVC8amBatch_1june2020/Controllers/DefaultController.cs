using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC8amBatch_1june2020.Models;
namespace MVC8amBatch_1june2020.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
         ViewBag.Name = "Prasad";//ViewBag is aDynamic property to send information to view

            return View();
        }

        public ActionResult GetSingleEmployee()
        {
            Employee obj = new Employee();
            obj.EmpId = 1;
            obj.EmpName = "Prasad";
            obj.EmpSalary = 21600;

            ViewBag.Employee = obj;
            return View();
        }

        public ActionResult GetMultipleEmployees()
        {
            List<Employee> emplistobj = new List<Employee>();
           
            Employee obj = new Employee();
            obj.EmpId = 1;
            obj.EmpName = "Prasad";
            obj.EmpSalary = 21600;

            Employee obj1 = new Employee();
            obj1.EmpId = 2;
            obj1.EmpName = "Prashanth";
            obj1.EmpSalary = 35000;

            Employee obj2 = new Employee();
            obj2.EmpId = 3;
            obj2.EmpName = "Radha";
            obj2.EmpSalary = 45000;

            emplistobj.Add(obj);
            emplistobj.Add(obj1);
            emplistobj.Add(obj2);

            ViewBag.Employees = emplistobj;
             
            return View();
        }

    }
}