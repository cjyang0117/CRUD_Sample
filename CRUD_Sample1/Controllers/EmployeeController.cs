using CRUD_Sample1.Models; //記得using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Sample1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeModel model = new EmployeeModel();
            model.EmployeeList = model.GetEmployeeList();

            return View(model);
        }
        
        public ActionResult Create()
        {
            //該類別是不是分開寫比較好，還是通常會寫在一起，這樣會new兩次...
            EmployeeModel model = new EmployeeModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            model.Add(model.Form1);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            EmployeeModel model = new EmployeeModel();
            model.Form1 = model.GetEmployee(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(EmployeeModel model)
        {
            model.Update(model.Form1);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            EmployeeModel model = new EmployeeModel();
            model.Form1 = model.GetEmployee(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(EmployeeModel model)
        {
            model.Delete(model.Form1.EmployeeID);
            return RedirectToAction("Index");
        }
    }
}