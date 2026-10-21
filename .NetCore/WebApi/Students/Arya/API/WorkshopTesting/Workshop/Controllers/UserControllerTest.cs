using Microsoft.AspNetCore.Mvc;

namespace Workshop.Controllers
{
    public class UserControllerTest : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
