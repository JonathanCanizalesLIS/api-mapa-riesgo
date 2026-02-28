using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosPago
{
    public int? EmpresaId { get; set; }

    public int? FpagoId { get; set; }

    public int? PromotorId { get; set; }

    public double? MontoPago { get; set; }

    public DateTime? Created { get; set; }

    public int Id { get; set; }

    public string? Estatus { get; set; }

    public string? DatosTransaccion { get; set; }

    public bool? Pagarpromotor { get; set; }

    public int? PendienteFacturar { get; set; }

    public decimal? ComisionPromotor { get; set; }

    public int? IdCorte { get; set; }

    public virtual PagosEmpresa? Empresa { get; set; }

    public virtual PagosFpago? Fpago { get; set; }

    public virtual ICollection<PagosCorte> PagosCortes { get; set; } = new List<PagosCorte>();

    public virtual PagosPromotore? Promotor { get; set; }
}
