using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.Ignore(x => x.PasswordConfirm);
    }
}