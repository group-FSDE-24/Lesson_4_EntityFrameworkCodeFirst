using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class AppUserDetail : BaseEntity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    // Fk
    public int AppUserId { get; set; }


    // Naviqation Property
    public AppUser AppUser { get; set; }


}
