using Microsoft.EntityFrameworkCore;

namespace Lab3
{
    public class Context: DbContext
    {
        public DbSet<Seller> Sellers { get; set; } 
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Warehouse> Warehouses { get; set; }
        
        public DbSet<ProductInWarehouse> ProductInWarehouses { get; set; }
        
        public DbSet<ProductSeller> ProductSellers { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Lab3;User=sa;Password=P@55w0rd;");
        }
    }
}