using FashiShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FashiShop.DAL.Concrete.Mapping
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.CategoryName).HasMaxLength(50).IsRequired();
        }
    }
}