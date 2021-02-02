using MVC_From_Scratch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_From_Scratch.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCustomer()
        {
            var customer = new Customer(1,"Haitham", "Amman", 20);
            return View(customer);
        }
    }
}