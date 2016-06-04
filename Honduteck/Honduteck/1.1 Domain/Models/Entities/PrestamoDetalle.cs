using System;
using System.Collections.Generic;
using Honduteck.Repositories.Generic;

namespace Honduteck.Models
{
    public partial class PrestamoDetalle :IEntity
    {
        public int CodigoPrestamo { get; set; }
        public int PeriodoId { get; set; }
        public decimal CuotaPeriodo { get; set; }
        public decimal SaldoPendiente { get; set; }
        public System.DateTime FechaTransaccion { get; set; }
        public virtual Prestamo Prestamo { get; set; }
    }
}
