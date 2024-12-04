using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NestFrontToBack.Models;

namespace NestFrontToBack.DAL;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Tag> Tags { get; set; }

    public DbSet<TagProduct> TagProducts { get; set; }

    public DbSet<ProductImage> ProductImages { get; set; }
}