using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionConceptoDeduccion
{
    public int IdDeduccion { get; set; }

    public string ClaveSat { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Comentario { get; set; }

    public string Estatus { get; set; } = null!;
}
