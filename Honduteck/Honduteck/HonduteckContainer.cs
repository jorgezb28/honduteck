using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Honduteck.Models;
using Honduteck._1._1_Domain.Repositories;
using Honduteck._1._1_Domain.Repositories.EntitiesRepositories;
using Honduteck._1._1_Domain.Repositories.Generic;
using Honduteck._1._2_Infraestructure;
using Microsoft.Practices.Unity;

namespace Honduteck
{
    public class HonduteckContainer
    {
        internal static void Configure(IUnityContainer container)
        {
            RegisterUnitofWork(container);
            RegisterRepositories(container);
        }

        private static void RegisterUnitofWork(IUnityContainer container)
        {
            container.RegisterType(typeof(HonduteckUnitofWork), new PerResolveLifetimeManager());
            container.RegisterType<IUnitofWork, HonduteckUnitofWork>();
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
