﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModeloDesSoftware.Repositorio.Repositorio;
using System;
using System.IO;
using System.Windows;

namespace WpfModuloDesSoftware
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EFContexto>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));

            //     services.AddDbContext<DataContext>
            //(options => options.UseSqlServer(
            //            Configuration.GetConnectionString("SqlConnection")));

            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();

            services.AddTransient(typeof(MainWindow));
        }
    }
}