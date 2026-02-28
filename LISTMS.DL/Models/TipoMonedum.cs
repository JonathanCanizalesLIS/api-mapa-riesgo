using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TipoMonedum
{
    public int IdTipoMoneda { get; set; }

    public string Clave { get; set; } = null!;

    public string Nombre { get; set; } = null!;
}
