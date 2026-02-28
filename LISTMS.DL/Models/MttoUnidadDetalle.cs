using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MttoUnidadDetalle
{
    public int IdEmpresa { get; set; }

    public int IdMtto { get; set; }

    public int Consecutivo { get; set; }

    public string? Actividad { get; set; }

    public int IdTipoAct { get; set; }

    public decimal ManoObra { get; set; }

    public decimal Refacciones { get; set; }

    public string Observaciones { get; set; } = null!;

    public virtual MttoUnidad Id { get; set; } = null!;
}
