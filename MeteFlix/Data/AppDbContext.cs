using Microsoft.AspnNetCore.IDentity.EntityFrameworkCore;


namespace MeteFlix.Data;

    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {   
        }

        public Dbset<AppUser> AppUsers { get; set; }
        public Dbset<Genre> Genres { get; set; }
    }
