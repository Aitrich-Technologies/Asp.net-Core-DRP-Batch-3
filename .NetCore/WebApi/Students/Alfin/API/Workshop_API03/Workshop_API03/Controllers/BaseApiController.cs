using Microsoft.AspNetCore.Mvc;

namespace Workshop_API03.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseApiController<T> : ControllerBase
    {
       
    }
}
