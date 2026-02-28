using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AlarmaTipoIdioma
{
    public int IdTipo { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual AlarmaTipo IdTipoNavigation { get; set; } = null!;
}
