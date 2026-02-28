using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PermisionarioTarifaTipoIdioma
{
    public int IdTipoTarifa { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }

    public virtual PermisionarioTarifaTipo IdTipoTarifaNavigation { get; set; } = null!;
}
