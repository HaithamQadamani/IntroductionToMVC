using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroductionToMVC.Controllers
{
    [RoutePrefix("Cars")]
    public class CarsController : Controller
    {
        // GET: Cars


        //Default page for website, without controller and action
        [Route("")]
        //no action , only controller
        //[Route("Cars")] removed at sample route prefix sample
        //default
        //[Route("Cars/Index")]
        [Route("Index")]
        public ContentResult Index()
        {
            //no view
            return Content("<h1>Attribute-based Routing Demo </h1>");
        }

        //multi action , use parameter 
        //[Route("Cars/Details/{id:int}")] removed at sample route prefix sample
        [Route("Details/{id:int}")]
        public ContentResult Details(int id)
        {
            return Content("<h2>Car id = " + id + "</h3>");
        }

        //[Route("Cars/Details/{name}")] removed at sample route prefix sample
        [Route("Details/{name}")]
        public ContentResult Details (string name)
        {
            return Content("<h2>Car name = " + name + "</h3>");
        }
    }
}