using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Tooltip
{
    public int IdTooltip { get; set; }

    public int IdVentana { get; set; }

    public string IdControl { get; set; } = null!;

    public string Evento { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string BuscarEnControl { get; set; } = null!;

    public string IdFormControl { get; set; } = null!;

    public string IdControlPrincipal { get; set; } = null!;

    public virtual Ventana IdVentanaNavigation { get; set; } = null!;

    public virtual ICollection<TooltipIdioma> TooltipIdiomas { get; set; } = new List<TooltipIdioma>();
}
