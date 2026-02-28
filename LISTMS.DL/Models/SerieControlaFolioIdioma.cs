using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SerieControlaFolioIdioma
{
    public int IdControla { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual SerieControlaFolio IdControlaNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
