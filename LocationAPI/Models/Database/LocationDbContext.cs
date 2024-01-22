using Microsoft.EntityFrameworkCore;

namespace LocationAPI.Models.Database
{
    public class LocationDbContext:DbContext
    {
        public LocationDbContext(DbContextOptions<LocationDbContext> options) : base(options) { }
        public DbSet<CountryModel> Countries { get; set; }
    }
}
