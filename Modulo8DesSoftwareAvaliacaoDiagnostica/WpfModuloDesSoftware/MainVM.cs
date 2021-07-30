using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ModeloDesSoftware.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WpfModuloDesSoftware
{
    public class MainVM
    {
       // EFContexto contexto;
        public MainVM()
        {
            //contexto = new EFContexto( new DbContextOptions
            //    (options =>
            //        options.UseSqlServer(ConfigurationManager.ConnectionStrings("CNX"), ServiceLifetime.Scoped));

        }

    }
}
