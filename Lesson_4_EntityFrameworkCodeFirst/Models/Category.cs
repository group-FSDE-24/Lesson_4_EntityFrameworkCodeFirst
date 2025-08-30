using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }


   //  // Naviqation Property
   //  public List<Product> Products { get; set; }
}
