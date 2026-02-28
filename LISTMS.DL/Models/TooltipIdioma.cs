using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TooltipIdioma
{
    public int IdTooltip { get; set; }

    public int IdIdioma { get; set; }

    public string? MarcaAgua { get; set; }

    public string? TextoAyuda { get; set; }

    public virtual Tooltip IdTooltipNavigation { get; set; } = null!;
}
