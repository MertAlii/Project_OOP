using Microsoft.EntityFrameworkCore;
using Project_OOP.Entity;

namespace Project_OOP.ProjeContext
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MERTALII\\SQLEXPRESS;database=DbNewOOPCore;integrated security=true;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
