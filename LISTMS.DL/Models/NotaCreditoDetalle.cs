using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCreditoDetalle
{
    public int IdCredito { get; set; }

    public int Consecutivo { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal MontoSubtotal { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal FactorIva { get; set; }

    public decimal FactorRetencion { get; set; }

    public int? IdConcepto { get; set; }

    public int IdObjetoImpuesto { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Monto { get; set; }

    public virtual GuiaConcepto? IdConceptoNavigation { get; set; }

    public virtual NotaCredito IdCreditoNavigation { get; set; } = null!;
}
