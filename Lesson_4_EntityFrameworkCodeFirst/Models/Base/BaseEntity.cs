namespace Lesson_4_EntityFrameworkCodeFirst.Models.Base;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }
}
