using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionEstatus
{
    public int IdEstatus { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();

    public virtual ICollection<LiquidacionEstatusIdioma> LiquidacionEstatusIdiomas { get; set; } = new List<LiquidacionEstatusIdioma>();

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();
}
