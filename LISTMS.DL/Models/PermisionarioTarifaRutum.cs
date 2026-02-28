using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PermisionarioTarifaRutum
{
    public int IdTarifaPermisionario { get; set; }

    public int IdRuta { get; set; }

    public decimal Monto { get; set; }

    public virtual ViajeRutum IdRutaNavigation { get; set; } = null!;

    public virtual PermisionarioTarifa IdTarifaPermisionarioNavigation { get; set; } = null!;
}
