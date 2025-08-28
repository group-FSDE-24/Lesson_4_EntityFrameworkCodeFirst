using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class Order : BaseEntity
{
    public string Address { get; set; }
}
