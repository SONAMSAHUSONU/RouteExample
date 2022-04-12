using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Route("Add /{x:int}/{y:int}")]
        public int addnumber(int i, int j)
        {
            int a = i + j;
            return a;
        }
    }
}