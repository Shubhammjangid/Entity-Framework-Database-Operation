using Bussiness;
using Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace Core.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBussiness _IEmployeeBussiness;
        public EmployeeController(IEmployeeBussiness IEmployeeBussiness)
        {
            _IEmployeeBussiness = IEmployeeBussiness;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _IEmployeeBussiness.AddEmployee(employee);
                return RedirectToAction("ShowDetail");
        }

        public ActionResult ShowDetail()
        {
            return View(_IEmployeeBussiness.ShowDetail());
        }

        public ActionResult Details(int Id)
        {
            return View(_IEmployeeBussiness.Details(Id));
        }

        public ActionResult Edit(int Id)
        {
            return View(_IEmployeeBussiness.Details(Id));
        }
        [HttpPost]
        public ActionResult Edit(int Id , Simple simple)
        {
            _IEmployeeBussiness.EditList(Id, simple);
            return RedirectToAction("ShowDetail");
        }

        public ActionResult Delete(int Id)
        {
            return View(_IEmployeeBussiness.Details(Id));
        }

        [HttpPost]
        public ActionResult Delete(Simple simple)
        {
            _IEmployeeBussiness.DeleteList(simple);
            return RedirectToAction("ShowDetail");
        }

        public ActionResult ExampleList()
        {
            return View (_IEmployeeBussiness.ExampleList());
        }

        
    }
}
