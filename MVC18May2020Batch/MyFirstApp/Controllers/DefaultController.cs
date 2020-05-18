using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Index()
        {
            return "hello world";
        }

        public string Contact(string Address)
        {
            return Address+" is famous for Hyderabadi Biryani";
        }
    }
}