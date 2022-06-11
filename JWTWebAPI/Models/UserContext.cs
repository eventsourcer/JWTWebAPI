using Microsoft.EntityFrameworkCore;

namespace JWTWebAPI.Models
{
    public class UserContext : DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
        public UserContext(DbContextOptions options) :base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User { Username="sarwan",Password="sarwan"},
                new User { Username = "postgres", Password = "postgres" }
                );
        }
        
    }
}
