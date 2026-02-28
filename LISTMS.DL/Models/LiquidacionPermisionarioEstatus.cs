using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionPermisionarioEstatus
{
    public int IdEstatus { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<LiquidacionPermisionarioEstatusIdioma> LiquidacionPermisionarioEstatusIdiomas { get; set; } = new List<LiquidacionPermisionarioEstatusIdioma>();

    public virtual ICollection<LiquidacionPermisionario> LiquidacionPermisionarios { get; set; } = new List<LiquidacionPermisionario>();
}
