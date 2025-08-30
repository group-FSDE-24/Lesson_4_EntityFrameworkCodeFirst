using Microsoft.EntityFrameworkCore;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class OrdersProductsConfiguration : IEntityTypeConfiguration<OrdersProducts>
{
    public void Configure(EntityTypeBuilder<OrdersProducts> builder)
    {
        builder.Ignore(x => x.Id);
        builder.Ignore(x => x.CreatedDate);
        builder.Ignore(x => x.ModifiedDate);

        builder.HasNoKey();

        builder.HasOne<Order>()
            .WithMany()
            .HasForeignKey(x => x.OrderId);


        builder.HasOne<Product>()
            .WithMany()
            .HasForeignKey(x => x.ProductId);
    }
}
