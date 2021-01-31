using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroductionToMVC.Models;

namespace IntroductionToMVC.Controllers
{
    public class ComputerController : Controller
    {
       public ActionResult Display()
        {
            var MyComputer = new Computer
            {
                Name = "Lenovo ThinkPad",
                Price = 500
            };
            return View(MyComputer);
        }
    }
}