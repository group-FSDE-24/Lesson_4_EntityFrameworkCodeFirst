using Microsoft.EntityFrameworkCore;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lesson_4_EntityFrameworkCodeFirst.Configurations;

class AppUserDetailConfiguration : IEntityTypeConfiguration<AppUserDetail>
{
    public void Configure(EntityTypeBuilder<AppUserDetail> builder)
    {
        throw new NotImplementedException();
    }
}
