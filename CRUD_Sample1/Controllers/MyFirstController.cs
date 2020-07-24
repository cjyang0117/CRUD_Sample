using CRUD_Sample1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Sample1.Controllers
{
    public class MyFirstController : Controller
    {
        // GET: MyFirst
        public ActionResult MVC()
        {
            MyFirsrModel model = new MyFirsrModel();
            model.Display = "Hello World!";

            return View(model);
        }
    }
}