using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosCorte
{
    public int? EmpresaId { get; set; }

    public int? PartidaId { get; set; }

    public int? PagoId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public double? Monto { get; set; }

    public int Id { get; set; }

    public int? Unidades { get; set; }

    public string? EstatusComision { get; set; }

    public string? ObservacionesComision { get; set; }

    public decimal? ComisionPromotor { get; set; }

    public virtual PagosEmpresa? Empresa { get; set; }

    public virtual PagosPago? Pago { get; set; }

    public virtual PagosPartida? Partida { get; set; }
}
