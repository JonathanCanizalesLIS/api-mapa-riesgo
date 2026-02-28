using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionPermisionarioGuium
{
    public int IdLiquidacionPermisionario { get; set; }

    public int Consecutivo { get; set; }

    public int IdViaje { get; set; }

    public int IdGuia { get; set; }

    public decimal Flete { get; set; }

    public string Referencia { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;

    public virtual LiquidacionPermisionario IdLiquidacionPermisionarioNavigation { get; set; } = null!;

    public virtual Viaje IdViajeNavigation { get; set; } = null!;
}
