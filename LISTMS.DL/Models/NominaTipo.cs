using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NominaTipo
{
    public int IdTiponomina { get; set; }

    public string Tiponomina { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<LiquidacionDirectum> LiquidacionDirecta { get; set; } = new List<LiquidacionDirectum>();

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();
}
