using Microsoft.AspNetCore.Mvc;
using Sample.Models;

namespace Sample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee();
            employee.Name = "Test";
            employee.Place = "Device";
            return View(employee);
        }
    }
}
