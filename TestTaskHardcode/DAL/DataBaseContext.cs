using TestTaskHardcode.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace TestTaskHardcode.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }
        public DbSet<CategoryToAttribute> CategoryToAttributes { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }


    }
}
