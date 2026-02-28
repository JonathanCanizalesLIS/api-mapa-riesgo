using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionPermisionarioEstatusIdioma
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }

    public virtual LiquidacionPermisionarioEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
