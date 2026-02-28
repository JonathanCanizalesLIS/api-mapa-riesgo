using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConvenioLiquidacionGasto
{
    public int IdConvenio { get; set; }

    public int IdConcepto { get; set; }

    public decimal Cantidad { get; set; }

    public int IdUnidadMedidaVolumen { get; set; }

    public decimal VolumenBase { get; set; }

    public decimal MontoSubtotal { get; set; }

    public decimal MontoIva { get; set; }

    public decimal MontoRetencion { get; set; }

    public decimal MontoTotal { get; set; }

    public string Referencia { get; set; } = null!;

    public int ConceptoGasto { get; set; }

    public virtual LiquidacionConcepto IdConceptoNavigation { get; set; } = null!;

    public virtual ConvenioLiquidacion IdConvenioNavigation { get; set; } = null!;
}
