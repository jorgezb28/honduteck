using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Honduteck.Models;
using Honduteck._1._1_Domain.Repositories;
using Honduteck._1._1_Domain.Repositories.EntitiesRepositories;
using Microsoft.Practices.Unity;

namespace Honduteck
{
    public class HonduteckContainer
    {
        internal static void Configure(IUnityContainer container)
        {
            RegisterRepositories(container);
        }

        private static void RegisterRepositories(IUnityContainer container)
        {
            container.RegisterType<ITipoClienteRepository,TipoClienteRepository>();
            container.RegisterType<ILugaresRepository, LugaresRepository>();
            container.RegisterType<IClienteRepository, ClienteRepository>();
            container.RegisterType<IPrestamoRepository, PrestamoRepository>();
            container.RegisterType<IPrestamoDetalleRepository, PrestamoDetalleRepository>();
        }
    }
}
