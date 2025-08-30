using Lesson_4_EntityFrameworkCodeFirst.Configurations;
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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration<AppUser>(new AppUserConfiguration());
        modelBuilder.ApplyConfiguration<AppUserDetail>(new AppUserDetailConfiguration());
        modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());
        modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
        

        base.OnModelCreating(modelBuilder);
    }



    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<AppUserDetail> AppUserDetails { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
}
