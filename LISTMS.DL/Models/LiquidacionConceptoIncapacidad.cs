using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionConceptoIncapacidad
{
    public int IdIncapacidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;
}
