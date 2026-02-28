using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionConceptoPercepcion
{
    public int IdPercepcion { get; set; }

    public string ClaveSat { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;
}
