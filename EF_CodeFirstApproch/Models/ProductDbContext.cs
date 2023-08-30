using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EF_CodeFirstApproch.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {
            
        }
        public DbSet<Products> ProductInfo { get; set; }
    }
}
