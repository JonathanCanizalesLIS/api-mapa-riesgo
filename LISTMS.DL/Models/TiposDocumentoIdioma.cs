using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TiposDocumentoIdioma
{
    public int IdDocumento { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }

    public virtual TiposDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
