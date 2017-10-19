using Microsoft.EntityFrameworkCore;
using MotMau.Core.Domain;
using System.Linq;

namespace MotMau.Data
{
    public class MotMauDataContext : DbContext
    {
        public MotMauDataContext(DbContextOptions<MotMauDataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
