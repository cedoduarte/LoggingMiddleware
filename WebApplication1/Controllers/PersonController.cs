using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("person")]
        public async Task<IActionResult> GetPersonById(int id)
        {
            return Ok(await _personService.GetPersonById(id));
        }

        [HttpGet("persons")]
        public async Task<IActionResult> GetPersons()
        {
            return Ok(await _personService.GetPersons());
        }
    }
}
