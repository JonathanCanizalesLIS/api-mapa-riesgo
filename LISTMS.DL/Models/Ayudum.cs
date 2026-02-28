using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Ayudum
{
    public int IdAyuda { get; set; }

    public string RutaArchivo { get; set; } = null!;

    public int IdIdioma { get; set; }

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
