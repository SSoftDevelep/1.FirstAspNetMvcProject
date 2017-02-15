using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1.FirstAspNetMvcProject.Controllers
{
    public class HomeController : Controller  //Controller classindan miras aliyor.
    {
        // GET: Home
        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult Kategoriler()
        {
            return View();
        }
    }
}