using System;
using System.Collections.Generic;
using Honduteck.Repositories.Generic;

namespace Honduteck.Models
{
    public partial class TipoCliente :IEntity 
    {
        public TipoCliente()
        {
            this.Clientes = new List<Cliente>();
        }

        public string CodigoTipo { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaTransaccion { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
