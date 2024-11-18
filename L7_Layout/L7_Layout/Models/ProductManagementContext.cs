using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace L7_Layout.Models
{
    public class ProductManagementContext:DbContext
    {
        public ProductManagementContext(DbContextOptions<ProductManagementContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Banner> Banner { get; set; }

    }
}
