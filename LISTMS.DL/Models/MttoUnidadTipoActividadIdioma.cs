using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MttoUnidadTipoActividadIdioma
{
    public int IdTipoAct { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual MttoUnidadTipoActividad IdTipoActNavigation { get; set; } = null!;
}
