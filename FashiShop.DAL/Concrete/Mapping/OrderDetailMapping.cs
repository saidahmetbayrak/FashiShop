using FashiShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FashiShop.DAL.Concrete.Mapping
{
    public class OrderDetailMapping : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(x=>new {x.OrderID, x.ProductID});
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(200);


        }
    }
}