using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionDirectaDetalle
{
    public int IdLiquidacionDirecta { get; set; }

    public int IdPercepcion { get; set; }

    public int? IdDeduccion { get; set; }

    public decimal? MontoGravable { get; set; }

    public decimal? MontoExcento { get; set; }

    public virtual LiquidacionConceptoDeduccion? IdDeduccionNavigation { get; set; }

    public virtual LiquidacionDirectum IdLiquidacionDirectaNavigation { get; set; } = null!;

    public virtual LiquidacionConceptoPercepcion IdPercepcionNavigation { get; set; } = null!;
}
