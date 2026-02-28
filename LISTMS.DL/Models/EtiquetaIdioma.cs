using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EtiquetaIdioma
{
    public int IdIdioma { get; set; }

    public string IdEtiqueta { get; set; } = null!;

    public string NombreEstandar { get; set; } = null!;

    public virtual Etiquetum IdEtiquetaNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
