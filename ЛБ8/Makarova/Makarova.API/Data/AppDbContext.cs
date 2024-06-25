using Flowers.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Yeroma.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

