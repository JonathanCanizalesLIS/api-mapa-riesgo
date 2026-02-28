using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionSueldoRutum
{
    public int IdTipoSueldo { get; set; }

    public int IdRuta { get; set; }

    public decimal Monto { get; set; }

    public virtual ViajeRutum IdRutaNavigation { get; set; } = null!;

    public virtual LiquidacionSueldo IdTipoSueldoNavigation { get; set; } = null!;
}
