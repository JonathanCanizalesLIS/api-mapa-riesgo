using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class HDisponibilidad
{
    public string IdEmpresa { get; set; } = null!;

    public string IdUnidad { get; set; } = null!;

    public DateTime FechaIni { get; set; }

    public DateTime FechaFin { get; set; }

    public int DiasMes { get; set; }

    public int DiasTaller { get; set; }

    public int DiasTrabajados { get; set; }

    public int EntradasATaller { get; set; }

    public string PkDisponibilidad { get; set; } = null!;
}
