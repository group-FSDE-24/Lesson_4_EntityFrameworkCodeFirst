using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class AppUserDetail : BaseEntity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }

}
