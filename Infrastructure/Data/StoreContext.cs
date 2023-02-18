using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;

namespace Infrastructure.Data
{
    public class StoreContext :DbContext
    {
        private readonly string con = "server=SKAYWINDESK; user = skay; password = Feb2023; database = Yoda; TrustServerCertificate = true";
        public StoreContext()
        {

        }

        
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(con);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<ShoppingCart> ShoppingCart { get; set; }

    }
}
