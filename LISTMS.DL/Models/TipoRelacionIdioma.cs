using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TipoRelacionIdioma
{
    public int IdTipoRelacion { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }
}
