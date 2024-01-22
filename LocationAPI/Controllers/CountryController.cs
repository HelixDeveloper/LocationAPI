using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LocationAPI.Models;

namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        List<CountryModel> countries = new List<CountryModel>{

                new CountryModel(){
                CountryId = 1,
                CountryName = "India"
                },
                new CountryModel(){
                CountryId = 2,
                CountryName = "USA"
                },
                new CountryModel(){
                CountryId = 3,
                CountryName = "Canada"
                },
                new CountryModel(){
                CountryId = 4,
                CountryName = "UK"
                },
            };


        [HttpGet(Name = "GetCountries")]
        public ActionResult<List<CountryModel>> Get()
        {

            return Ok(countries);
        }

        [HttpGet("{id}")]
        public ActionResult<CountryModel> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id should not be zero or negative");
            }

            return Ok(countries.Where(a => a.CountryId == id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] VMCountry country)
        {
            try
            {

                if (country == null)
                {
                    return BadRequest("Please add valid data!");
                }
                countries.Add(new CountryModel() { 
                    CountryId = 0,
                    CountryCode = country.CountryCode,
                    CountryName = country.CountryName,
                });
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
