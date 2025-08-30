using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public double UnitPrice { get; set; }
    public int UnitInStock { get; set; }

    public int CategoryId { get; set; }// [ForeignKey("CategoryId")]




    //    // Naviqation Property
    //    public Category Category { get; set; }
    //    public List<Order> Orders { get; set; }
}

