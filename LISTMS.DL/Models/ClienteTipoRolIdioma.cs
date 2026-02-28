using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ClienteTipoRolIdioma
{
    public int IdRol { get; set; }

    public int IdIdioma { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual ClienteTipoRol IdRolNavigation { get; set; } = null!;
}
