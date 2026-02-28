using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SeguridadGrupoIdioma
{
    public int IdGrupo { get; set; }

    public int IdIdioma { get; set; }

    public string? Descripcion { get; set; }

    public string? Nombre { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual SeguridadGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
