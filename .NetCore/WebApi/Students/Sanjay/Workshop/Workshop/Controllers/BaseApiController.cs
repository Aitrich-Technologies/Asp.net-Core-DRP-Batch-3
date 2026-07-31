using Microsoft.AspNetCore.Mvc;

namespace Workshop.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseApiController<T> : ControllerBase
    {
    }
}