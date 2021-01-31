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


        //Default page for website, without controller and action
        [Route("")]
        //no action , only controller
        [Route("Cars")]
        //default
        [Route("Cars/Index")]
        public ContentResult Index()
        {
            //no view
            return Content("<h1>Attribute-based Routing Demo </h1>");
        }

        //multi action , use parameter 
        [Route("Cars/Details/{id}")]
        public ContentResult Details(int id)
        {
            return Content("<h2>Car id = " + id + "</h3>");
        }
    }
}