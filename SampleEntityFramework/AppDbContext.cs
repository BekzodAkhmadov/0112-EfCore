using Microsoft.EntityFrameworkCore;

namespace SampleEntityFramework
{
    public class AppDbContext : DbContext
    {
        public DbSet<BlogPost> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Data source=appdb.db";
            optionsBuilder.UseSqlite(connString);
           // .LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }


    }
}