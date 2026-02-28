using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SeguridadMenuIdioma
{
    public int IdMenu { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;
}
