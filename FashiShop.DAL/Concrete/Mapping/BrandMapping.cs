using FashiShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FashiShop.DAL.Concrete.Mapping
{
    public class BrandMapping : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brand");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.BrandName).HasMaxLength(50).IsRequired();
            
        }
    }
}