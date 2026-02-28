using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoAdendaIdioma
{
    public int IdAdenda { get; set; }

    public int IdIdioma { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ElectronicoAdendum IdAdendaNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
