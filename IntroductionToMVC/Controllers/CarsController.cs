using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroductionToMVC.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars

        [Route("Cars/Index")]
        public ContentResult Index()
        {
            //no view
            return Content("<h1>Attribute-based Routing Demo </h1>");
        }
    }
}