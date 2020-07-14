
using FashiShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FashiShop.DAL.Concrete.Mapping
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.OrderDate).HasColumnType("datetime2");
            builder.Property(a => a.ShippedDate).HasColumnType("datetime2");
            builder.Property(a => a.Phone).HasMaxLength(11).IsRequired();
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.City).IsRequired();
            builder.Property(a => a.Town).IsRequired();
            builder.Property(a => a.Address).HasMaxLength(400).IsRequired();
        }
    }
}