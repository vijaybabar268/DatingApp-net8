using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DatingDataContext : DbContext
    {
        public DatingDataContext(DbContextOptions<DatingDataContext> options)
            : base(options)
        {
            //...
        }

        public DbSet<AppUser> Users { get; set; }
    }
}