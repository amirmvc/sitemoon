using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        [Authorize(Roles = "Admin")]
        // GET: Test
        public ActionResult test1()
        {
            return View();
        }
        public ActionResult test2()
        {
            return View();
        }
    }
}