<<<<<<< HEAD
using femblogAPI.Models;
using Microsoft.EntityFrameworkCore;
=======
using Microsoft.EntityFrameworkCore;
using femblogAPI.Models;
>>>>>>> d38ac58575da3c3b06520527d885d0e2e3824271

namespace femblogAPI.Data
{
    public class femblogapiContext : DbContext
    {
<<<<<<< HEAD
=======

        

>>>>>>> d38ac58575da3c3b06520527d885d0e2e3824271
        public femblogapiContext(DbContextOptions<femblogapiContext> options) : base(options)
        {
            
        }

<<<<<<< HEAD
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
=======
        public DbSet<Post> Posts {get; set;}
        public DbSet<User> Users { get; set; }
    }

}
>>>>>>> d38ac58575da3c3b06520527d885d0e2e3824271
