using ClienteManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClienteManager.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; } = null!;
}