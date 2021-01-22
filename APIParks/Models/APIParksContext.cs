using Microsoft.EntityFrameworkCore;

namespace APIParks.Models
{
    public class APIParksContext : DbContext
    {
        public APIParksContext(DbContextOptions<APIParksContext> options)
            : base(options)
        {
        }

        public DbSet<State> States { get; set; }
        public DbSet<National> Nationals { get; set; }
    }
}