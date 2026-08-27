using ClienteManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace ClienteManager.Presentation;

public partial class App : System.Windows.Application
{
    public static IServiceProvider Services { get; private set; } = null!;

    public App()
    {
        var services = new ServiceCollection();

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=clientes.db"));

        Services = services.BuildServiceProvider();
    }
}