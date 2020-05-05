using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
              return View();
            }
        }
    }
}