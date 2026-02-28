using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TipoExportacionIdioma
{
    public int IdTipoExportacion { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }
}
