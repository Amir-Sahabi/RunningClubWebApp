using Microsoft.EntityFrameworkCore;
using RunningClubWebApp.Models;

namespace RunningClubWebApp.Data.DataBaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }



    }

}
