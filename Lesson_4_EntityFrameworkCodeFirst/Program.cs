using Lesson_4_EntityFrameworkCodeFirst.Context;
using Lesson_4_EntityFrameworkCodeFirst.Models;
using Lesson_4_EntityFrameworkCodeFirst.Models.Base;
using Lesson_4_EntityFrameworkCodeFirst.ResponseModel;

namespace Lesson_4_EntityFrameworkCodeFirst;


/*
 
AppUser
AppUserDetail

Category
Product
Order


--------------------------

One to One
AppUser
AppUserDetail
 
One to Many
Category Product
User Order

Many to Many
Product Order


// Navigation Property
// Data Annotation


// Relational Table

1. Convertional 
2. DataAnnotation
3. Fluent API 

 */


class Program
{
    static void Main(string[] args)
    {
        var context = new AppDbContext();

        // context.Categories.Add(new Category()
        // {
        //     Name = "Sud mehsullari",
        //     Description = "Umumen nese 1 sey"
        // });
        // 
        // context.Products.Add(new Product()
        // {
        //     Name = "Yogurt",
        //     UnitPrice = 99.9,
        //     UnitInStock = 50,
        //     CategoryId = 1
        // });


        Console.WriteLine("Successfully added Product");


        var list = context.Products
                                    .Where(x => x.Id == 3)
                                    .Select(x => new GetProductResponseModel
                                    {
                                        Name = x.Name,
                                        UnitPice = x.UnitPrice
                                    })
                                    .ToList();

        foreach (var item in list)
        {
            Console.WriteLine($"{item.Name} - {item.UnitPice}");
        }


        var productOne = context.Products.FirstOrDefault(x => x.Id == 1);

        productOne.Name = "Kelem dolmasi";

        context.SaveChanges();

    }
}