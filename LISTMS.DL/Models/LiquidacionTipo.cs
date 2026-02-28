using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionTipo
{
    public int IdLiquidacionTipo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();
}
