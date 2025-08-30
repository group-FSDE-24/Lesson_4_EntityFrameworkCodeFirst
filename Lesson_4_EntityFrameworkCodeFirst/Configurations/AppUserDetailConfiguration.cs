using Microsoft.EntityFrameworkCore;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class AppUserDetailConfiguration : IEntityTypeConfiguration<AppUserDetail>
{
    public void Configure(EntityTypeBuilder<AppUserDetail> builder)
    {
        builder.Property(x => x.Firstname)
            .IsRequired()
            .HasDefaultValue("No Name")
            .HasColumnName("Name");

        builder.Property(x => x.Lastname)
            .IsRequired()
            .HasDefaultValue("No Surname")
            .HasColumnName("Surname");


        builder.HasOne<AppUser>()
            .WithOne()
            .HasForeignKey<AppUserDetail>(x => x.AppUserId);

    }
}
