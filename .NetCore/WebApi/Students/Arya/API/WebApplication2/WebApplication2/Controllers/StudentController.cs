using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StudentController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return Ok("Hello Arya");
        //}

        [HttpGet]
        public IActionResult message()
        {
            return Ok("Exploring korea");
        }
    }
}
