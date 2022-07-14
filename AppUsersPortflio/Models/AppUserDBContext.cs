using Microsoft.EntityFrameworkCore;

namespace AppUsersPortflio.Models
{
    public class AppUserDBContext : DbContext
    {
        public AppUserDBContext(DbContextOptions<AppUserDBContext> options) : base(options)
        {

        }

        //Table Creation

        public DbSet<AppUser> AppUsers { get; set; }

    }
}
