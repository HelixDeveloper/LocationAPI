using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LocationAPI.Models;
using LocationAPI.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly LocationDbContext _context;
        public CountryController(LocationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryModel>>> GetCountries()
        {
            return await _context.Countries.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CountryModel>> GetCountrybyId(int id)
        {
            var obj = await _context.Countries.FindAsync(id);

            if (obj == null)
            {
                return NotFound();
            }

            return obj;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] VMCountry country)
        {
            CountryModel obj = new CountryModel()
            {
                CountryName = country.CountryName,
                CountryCode = country.CountryCode


            };
            

            _context.Countries.Add(obj);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] VMCountry country)
        {
            var existing=await _context.Countries.FindAsync(id);
            if(id==null)
            {
                return NotFound();
            }
            existing.CountryName = country.CountryName;
            existing.CountryCode=country.CountryCode;
            //_context.Countries.Add(existing);
            await _context.SaveChangesAsync();
            return Ok();
        }
        
    }
}
