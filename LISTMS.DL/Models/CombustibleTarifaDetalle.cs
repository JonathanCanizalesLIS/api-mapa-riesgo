using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class CombustibleTarifaDetalle
{
    public int IdTarifa { get; set; }

    public int IdCombustible { get; set; }

    public decimal MontoTarifa { get; set; }

    public decimal FactorIeps { get; set; }

    public virtual Combustible IdCombustibleNavigation { get; set; } = null!;

    public virtual CombustibleTarifa IdTarifaNavigation { get; set; } = null!;
}
