using Microsoft.EntityFrameworkCore;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        throw new NotImplementedException();
    }
}
