using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class Order : BaseEntity
{
    public string Address { get; set; }


    // Fk
    public int AppUserId { get; set; }


    // Naviqation Property
    public AppUser AppUser { get; set; }
    public List<Product> Products { get; set; }


}
