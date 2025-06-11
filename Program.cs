using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Proyecto_1_PAvanzada
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddTransient<frmSuplidores>();
            services.AddTransient<SuplidoresRepo>();
            services.AddTransient<frmCategorias>();
            services.AddTransient<CategoriasRepo>();
            services.AddTransient<frmProductos>();
            services.AddTransient<ProductoRepo>();
            services.AddTransient<ImagenRepo>();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient<Inicio>();

            var serviceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetService<Inicio>();
            Application.Run(mainForm);
        }
    }
}