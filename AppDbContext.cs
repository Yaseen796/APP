using Microsoft.EntityFrameworkCore;
using DotNet8SampleApp.Models;

namespace DotNet8SampleApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
