using FashiShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FashiShop.DAL.Concrete.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           builder.ToTable("User");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.Firstname).HasMaxLength(50);
            builder.Property(a => a.Lastname).HasMaxLength(50);
            builder.Property(a => a.UserName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.Password).IsRequired();
        }
    }
}