using Database4Adult1.Domain;
using Microsoft.EntityFrameworkCore;

namespace Database4Adult1.Persistence
{
    public class AdultContext : DbContext
    {
        public DbSet<Adult> Adults {get; set; }
        public DbSet<User> User {get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Namet på Databasen
            optionsBuilder.UseSqlite(@"Data Source = Adult.db");
        } 
    }
}