using BlzCrud.Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlzCrud.Backend.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; } = null!;
}