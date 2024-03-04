using Inventario.Application.DataContext;
using Inventario.Application.Repositories;
using Inventario.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Inventario.Desktop {
    internal static class Program {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            using (var scope = host.Services.CreateScope()) {
                var db = scope.ServiceProvider.GetRequiredService<InventoryDbContext>();
                db.Database.Migrate();
            }

            ServiceProvider = host.Services;
            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        static IHostBuilder CreateHostBuilder() {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContextFactory<InventoryDbContext>(options =>
                        options.UseSqlite("Data Source=inventory.sqlite"));
                    services.AddTransient<IUnitOfWork, UnitOfWork>();
                    services.AddTransient<IRepository<Product>, ProductRepository>();
                    services.AddTransient<Catalog.ProductForm>();
                    services.AddTransient<Catalog.NewProductForm>();
                    services.AddTransient<Catalog.CategoriesForm>();
                    services.AddTransient<Catalog.ProvidersForm>();
                    services.AddTransient<Catalog.NewCategoryForm>();
                    services.AddTransient<Catalog.NewProviderForm>();
                    services.AddTransient<MainForm>();
                });
        }
    }
}