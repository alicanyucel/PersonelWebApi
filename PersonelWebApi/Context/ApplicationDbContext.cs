using Microsoft.EntityFrameworkCore;
using PersonelWebApi.Model;

namespace PersonelWebApi.Context
{
    public sealed class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
        public DbSet<Personel> Personels { get; set; }
    }
}
