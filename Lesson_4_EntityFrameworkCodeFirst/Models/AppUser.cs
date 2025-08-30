using Lesson_4_EntityFrameworkCodeFirst.Enums;
using Lesson_4_EntityFrameworkCodeFirst.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class AppUser : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }

    // [NotMapped]
    public string PasswordConfirm { get; set; }
    public Roles Roles { get; set; }



    // // Naviqation Property
    // public AppUserDetail AppUserDetail { get; set; }
    // public List<Order> Orders { get; set; }


}
