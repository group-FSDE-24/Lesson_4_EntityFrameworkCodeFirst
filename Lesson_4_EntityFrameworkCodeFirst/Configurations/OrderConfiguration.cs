using Microsoft.EntityFrameworkCore;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        throw new NotImplementedException();
    }
}
