using Microsoft.EntityFrameworkCore;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Name)
             .IsRequired()
             .HasMaxLength(10)
             .HasDefaultValue("Default");


        // builder.HasQueryFilter(x => x.CreatedDate < new DateTime(2007, 1, 1));
    }
}
