using Lesson_4_EntityFrameworkCodeFirst.Enums;
using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class AppUser : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string PasswordConfirm { get; set; }
    public Roles Roles { get; set; }



    // Naviqation Property
    public AppUserDetail AppUserDetail { get; set; }
    public List<Order> Orders { get; set; }


}
