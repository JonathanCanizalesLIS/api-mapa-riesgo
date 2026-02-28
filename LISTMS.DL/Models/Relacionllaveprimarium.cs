using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Relacionllaveprimarium
{
    public int IdPrimario { get; set; }

    public int IdEmpresa { get; set; }

    public string Identificador { get; set; } = null!;

    public int IdRelacion { get; set; }
}
