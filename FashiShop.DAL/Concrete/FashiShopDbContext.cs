using FashiShop.DAL.Concrete.Mapping;
using FashiShop.Model;
using Microsoft.EntityFrameworkCore;


namespace FashiShop.DAL.Concrete
{
    public class FashiShopDbContext : DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=FashiShopDB;Trusted_Connection=True");
    }
        
        public  DbSet<Brand> Brands { get; set; }
        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<OrderDetail> OrderDetails { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<User> Users { get; set; }
            
       protected override void OnModelCreating(ModelBuilder modelBuilder){

           modelBuilder.ApplyConfiguration(new BrandMapping());
           modelBuilder.ApplyConfiguration(new CategoryMapping());
           modelBuilder.ApplyConfiguration(new OrderDetailMapping());
           modelBuilder.ApplyConfiguration(new OrderMapping());
           modelBuilder.ApplyConfiguration(new ProductMapping());
           modelBuilder.ApplyConfiguration(new UserMapping());
           
           
           modelBuilder.Entity<Product>()
           .HasOne<Brand>(x => x.Brand)
           .WithMany(p => p.Products)
           .HasForeignKey(s => s.BrandId);
           
           modelBuilder.Entity<Product>()
           .HasOne<Category>(x => x.Category)
           .WithMany(p => p.Products)
           .HasForeignKey(s => s.CategoryID);
           
           modelBuilder.Entity<Order>()
           .HasOne<User>(x => x.UserDetail)
           .WithMany(p => p.Orders)
           .HasForeignKey(s => s.UserDetailID);

           modelBuilder.Entity<OrderDetail>()
           .HasOne<Order>(x => x.Order)
           .WithMany(p => p.OrderDetails)
           .HasForeignKey(s => s.OrderID);

           modelBuilder.Entity<OrderDetail>()
           .HasOne<Product>(x => x.Product)
           .WithMany(p => p.OrderDetails)
           .HasForeignKey(s => s.ProductID);
        }
    }
}