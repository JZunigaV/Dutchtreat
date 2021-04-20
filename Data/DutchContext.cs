using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DutchTreat.Data.Entities
{
    public class DutchContext : DbContext
    {
        private readonly IConfiguration _config;

        public DutchContext(IConfiguration config)
        {
            _config = config;

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DutchContextDb"]);
        }
    }
}