using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoAdendaCamposDefault
{
    public int IdEmpresa { get; set; }

    public int IdAdenda { get; set; }

    public int Consecutivo { get; set; }

    public string? Valor { get; set; }

    public virtual ElectronicoAdendaCampo ElectronicoAdendaCampo { get; set; } = null!;
}
