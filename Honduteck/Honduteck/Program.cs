using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Honduteck.Models;
using Honduteck._1._1_Domain.Repositories;
using Microsoft.Practices.Unity;

namespace Honduteck
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormTipoClientes>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            HonduteckContainer.Configure(container);
            return container;
        }
    }
}
