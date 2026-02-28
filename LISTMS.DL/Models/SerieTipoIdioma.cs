using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SerieTipoIdioma
{
    public int IdTipoSerie { get; set; }

    public int IdIdioma { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual SerieTipo IdTipoSerieNavigation { get; set; } = null!;
}
