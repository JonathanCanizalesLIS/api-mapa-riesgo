using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Iep
{
    public int IdIeps { get; set; }

    public int IdEmpresa { get; set; }

    public int Anio { get; set; }

    public int Mes { get; set; }

    public int IdCombustible { get; set; }

    public decimal FactorIeps { get; set; }

    public string Periodo { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual Combustible IdCombustibleNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;
}
