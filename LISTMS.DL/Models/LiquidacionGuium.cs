using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionGuium
{
    public int IdLiquidacion { get; set; }

    public int Consecutivo { get; set; }

    public int? IdViaje { get; set; }

    public int? IdGuia { get; set; }

    public decimal Flete { get; set; }

    public virtual Guium? IdGuiaNavigation { get; set; }

    public virtual Liquidacion IdLiquidacionNavigation { get; set; } = null!;

    public virtual Viaje? IdViajeNavigation { get; set; }
}
