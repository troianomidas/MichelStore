using MichelStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MichelStore.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DependencyInjection).Assembly);
}