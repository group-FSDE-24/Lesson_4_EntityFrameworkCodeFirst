using Microsoft.EntityFrameworkCore;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.UnitPrice)
            .IsRequired()
            .HasDefaultValue(0M)
            .HasColumnType("decimal(18,2)");


        builder.HasOne<Category>()
            .WithMany()
            .HasForeignKey(x => x.CategoryId);
    }
}
