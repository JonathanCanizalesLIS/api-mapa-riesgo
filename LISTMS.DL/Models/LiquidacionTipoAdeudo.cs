using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionTipoAdeudo
{
    public int IdTipoAdeudo { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<LiquidacionTipoAdeudoIdioma> LiquidacionTipoAdeudoIdiomas { get; set; } = new List<LiquidacionTipoAdeudoIdioma>();

    public virtual ICollection<Liquidacion> Liquidacions { get; set; } = new List<Liquidacion>();
}
