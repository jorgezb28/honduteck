using System;
using System.Collections.Generic;
using Honduteck.Repositories.Generic;

namespace Honduteck.Models
{
    public partial class Prestamo : IEntity
    {
        public Prestamo()
        {
            this.DetallePrestamoes = new List<PrestamoDetalle>();
        }

        public int CodigoPrestamo { get; set; }
        public string CodigoCliente { get; set; }
        public int Monto { get; set; }
        public System.DateTime FechaSolicitud { get; set; }
        public System.DateTime FechaAcreditacion { get; set; }
        public int NoQuincenas { get; set; }
        public bool EstaAcreditado { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaTransaccion { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<PrestamoDetalle> DetallePrestamoes { get; set; }
    }
}
