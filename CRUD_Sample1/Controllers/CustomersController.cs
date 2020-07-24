using CRUD_Sample1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Sample1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            CustomersModel model = new CustomersModel();
            model.CustomersList = model.GetCustomersList();

            return View(model);
        }
    }
}