using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee obj = new Models.Employee();
            obj.EmpId = 1;
            obj.EmpName = "Vijay";
            obj.EmpSalary = 25000;

            Department deptobj = new Models.Department();
            deptobj.DeptId = 1211;
            deptobj.DeptName = "IT";

            EmployeeDept objempdept = new Models.EmployeeDept();
            objempdept.emp = obj;
            objempdept.dept = deptobj;

            return View(objempdept);
        }

        public ViewResult GetAllEmployee()
        {
            Employee obj = new Models.Employee();
            obj.EmpId = 1;
            obj.EmpName = "Vijay";
            obj.EmpSalary = 25000;

            Employee obj1 = new Models.Employee();
            obj1.EmpId = 2;
            obj1.EmpName = "Dora";
            obj1.EmpSalary = 35000;


            List<Employee> listobj = new List<Employee>();
            listobj.Add(obj);
            listobj.Add(obj1);

            return View("GetAllEmployee",listobj);
        }


        public PartialViewResult GetmyPartialView() {
            Employee obj = new Models.Employee();
            obj.EmpId = 1;
            obj.EmpName = "Vijay";
            obj.EmpSalary = 25000;

            Employee obj1 = new Models.Employee();
            obj1.EmpId = 2;
            obj1.EmpName = "Dora";
            obj1.EmpSalary = 35000;


            List<Employee> listobj = new List<Employee>();
            listobj.Add(obj);
            listobj.Add(obj1);

            return PartialView("_MyPartialView",listobj);
        }


    }
}