using System;
using System.Collections.Generic;
using Honduteck.Repositories.Generic;

namespace Honduteck.Models
{
    public partial class Lugares : IEntity
    {
        public Lugares()
        {
            this.Clientes = new List<Cliente>();
        }

        public int CodigoLugar { get; set; }
        public string Descripcion { get; set; }
        public string OficialEncargado { get; set; }
        public System.DateTime FechaTransaccion { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
