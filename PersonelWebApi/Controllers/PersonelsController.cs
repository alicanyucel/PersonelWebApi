using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonelWebApi.Dros;
using PersonelWebApi.Services;

namespace PersonelWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonelsController(IPersonelService personelService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var personels = personelService.GetAll();
            return Ok(personels);
        }
        [HttpPost]
        public IActionResult Create(CreatePersonelDto request)
        {
            var result = personelService.Create(request);
            if (!result) return BadRequest(new { Message = "Something went wrong" });
            return Ok(new { Message = "Personel create is successful" });
        }
    }
}
