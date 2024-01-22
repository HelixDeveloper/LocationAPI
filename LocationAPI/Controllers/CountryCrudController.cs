using LocationAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryCrudController : ControllerBase
    {
        // GET: api/<CountryCrudController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CountryCrudController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CountryCrudController>
        [HttpPost]
        public IActionResult Post([FromBody] CountryCRUDVM country)
        {
            try
            {
                CountryCRUDModel model = new CountryCRUDModel()
                {
                    CountryCode = country.CountryCode,
                    CountryName = country.CountryName,
                };
                //Add this model in dbcontext
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CountryCrudController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountryCrudController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
