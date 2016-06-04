using System;
using System.Collections.Generic;
using Honduteck.Repositories.Generic;

namespace Honduteck.Models
{
    public partial class Cliente : IEntity
    {
        public Cliente()
        {
            this.Prestamoes = new List<Prestamo>();
        }

        public string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string CuentaBarcaria { get; set; }
        public int Lugar { get; set; }
        public string TipoCliente { get; set; }
        public string Banco { get; set; }
        public System.DateTime FechaTransaccion { get; set; }
        public virtual Lugares Lugares { get; set; }
        public virtual TipoCliente TipoCliente1 { get; set; }
        public virtual ICollection<Prestamo> Prestamoes { get; set; }
    }
}
