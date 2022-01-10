using DomainModel;
using Microsoft.EntityFrameworkCore;

namespace AviationWebAPI.DatabaseContext
{
    public class AviationContext:DbContext
    {
        public AviationContext(DbContextOptions<AviationContext>options)
            : base(options)
        {

        }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
