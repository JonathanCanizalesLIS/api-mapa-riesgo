using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaTipoDocumentoIdioma
{
    public int IdTipoDocumento { get; set; }

    public int IdIdioma { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual GuiaTipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;
}
