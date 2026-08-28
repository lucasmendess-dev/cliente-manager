using ClienteManager.Application.Interfaces;
using ClienteManager.Infrastructure.Data;
using ClienteManager.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ClienteManager.Presentation;

public partial class App : System.Windows.Application
{
    public static IServiceProvider Services { get; private set; } = null!;

    public App()
    {
        var services = new ServiceCollection();

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=clientes.db"));

        services.AddScoped<IClienteRepository, ClienteRepository>();

        Services = services.BuildServiceProvider();
    }
}