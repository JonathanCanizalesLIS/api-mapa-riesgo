using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SeguridadAyudaIdioma
{
    public int IdIdioma { get; set; }

    public int IdAyuda { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual SeguridadAyudum IdAyudaNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
