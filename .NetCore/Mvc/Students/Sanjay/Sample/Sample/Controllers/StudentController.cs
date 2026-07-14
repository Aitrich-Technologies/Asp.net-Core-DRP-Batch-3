using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Name = "Arya";
            //ViewBag.Place = "Ekm";

            ViewData["Name"] = "ALfin";
            ViewData["Place"] = "Paravoor";

            return View();
        }
    }
}
