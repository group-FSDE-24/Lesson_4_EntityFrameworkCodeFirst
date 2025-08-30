using Lesson_4_EntityFrameworkCodeFirst.Models.Base;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class AppUserDetail : BaseEntity
{

    public string Firstname { get; set; } //[Column("Ad")
    public string Lastname { get; set; } //[Column("Ad")]
    
    
    public int AppUserId { get; set; } // [ForeignKey("AppUserId")]


    //  // Naviqation Property
    //  public AppUser AppUser { get; set; }
}
