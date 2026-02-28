using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionPermisionarioDetalle
{
    public int IdLiquidacionPermisionario { get; set; }

    public int Consecutivo { get; set; }

    public int IdConcepto { get; set; }

    public string Referencia { get; set; } = null!;

    public decimal Subtotal { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal MontoTotal { get; set; }

    public int IdRetencion { get; set; }

    public int TipoConcepto { get; set; }

    public virtual ConceptoPermisionario IdConceptoNavigation { get; set; } = null!;

    public virtual LiquidacionPermisionario IdLiquidacionPermisionarioNavigation { get; set; } = null!;

    public virtual Impuesto IdRetencionNavigation { get; set; } = null!;
}
