using Lesson_4_EntityFrameworkCodeFirst.Models.Base;

namespace Lesson_4_EntityFrameworkCodeFirst.Models;

public class OrdersProducts : BaseEntity
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
}
