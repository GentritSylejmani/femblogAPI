using Microsoft.EntityFrameworkCore;
using femblogAPI.Models;

namespace femblogAPI.Data
{
    public class femblogapiContext : DbContext
    {
        public femblogapiContext(DbContextOptions<femblogapiContext> options) : base(options)
        {
            
        }

        public DbSet<Post> Posts {get; set;}
        public DbSet<User> Users { get; set; }
    }

}