using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonelWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonelsController : ControllerBase
    {
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return Create();
        }
    }
}
