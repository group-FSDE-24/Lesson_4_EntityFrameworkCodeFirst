using Microsoft.EntityFrameworkCore;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        throw new NotImplementedException();
    }
}
