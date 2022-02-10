using Bussiness;
using Microsoft.AspNetCore.Mvc;
using Model;

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
            return View();
        }
    }
}
