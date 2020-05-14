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

        //[HttpPost]
        //public ActionResult Create(Employee empobj)
        //{
        //    int i=obj.SaveEmployee(empobj);
        //    if (i > 0)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View(empobj);
        //    }
        //}


        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            Employee empobj = new Employee();
            empobj.EmpName =frm["EmpName"];
            empobj.EmpSalary =Convert.ToInt32(frm["EmpSalary"]);

            int i = obj.SaveEmployee(empobj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(empobj);
            }
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Employee empobj = obj.GetEmployeeById(id);
            return View(empobj);

        }

        [HttpPost]
        public ActionResult Edit(Employee empobj)
        {
            int i = obj.UpdateEmployee(empobj);
            if (i > 0)
            {
                return RedirectToAction("GetEmployee");
            }
            else
            {
                return View(empobj);
            }

        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Employee empobj = obj.GetEmployeeById(id);
            return View(empobj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = obj.DeleteEmployeeById(id);
            if (i > 0)
            {
                return RedirectToAction("GetEmployee");
            }
            else
            {
                return View();
            }
            
        }
    }
}

