using Lesson_4_EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson_4_EntityFrameworkCodeFirst.Context;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopAppDB;Integrated Security=True;Connect Timeout=30;");
        base.OnConfiguring(optionsBuilder);
    }

    // Arasdirma NotMapped-in qarsiligi


    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<AppUserDetail> AppUserDetails { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
}
