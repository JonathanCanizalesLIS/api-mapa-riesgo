using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadTipoRolIdioma
{
    public int IdRol { get; set; }

    public int IdIdioma { get; set; }

    public string? Nombre { get; set; }

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual UnidadTipoRol IdRolNavigation { get; set; } = null!;
}
