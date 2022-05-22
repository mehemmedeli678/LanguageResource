using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class TestDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8O2DBOG;Database=TextDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Aboutlanguage>? Aboutlanguages { get; set; }
    }
}
