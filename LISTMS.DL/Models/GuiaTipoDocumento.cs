using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaTipoDocumento
{
    public int IdTipoDocumento { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Guium> Guia { get; set; } = new List<Guium>();

    public virtual ICollection<GuiaTipoDocumentoIdioma> GuiaTipoDocumentoIdiomas { get; set; } = new List<GuiaTipoDocumentoIdioma>();
}
