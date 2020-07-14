using FashiShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FashiShop.DAL.Concrete.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ProductName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Stock).IsRequired();
            builder.Property(a => a.Price).IsRequired();
        }
    }
}