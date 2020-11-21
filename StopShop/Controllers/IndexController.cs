using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StopShop.Controllers
{
    public class IndexController : Controller
    {
        // this is how you use it
        // [Route]
        //routes.MapMvcAttributeRoutes();
        // GET: Index
        public ActionResult Index()
        {
            

            return Content("Hello World 2");
        }
    }
}