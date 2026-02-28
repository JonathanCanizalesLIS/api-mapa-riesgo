using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCreditoEstatusIdioma
{
    public int IdEstatus { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual NotaCreditoEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
