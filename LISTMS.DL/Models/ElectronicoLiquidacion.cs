using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoLiquidacion
{
    public int IdLiqElectronica { get; set; }

    public int IdDocumento { get; set; }

    public int IdLiquidacion { get; set; }

    public int IdEstatus { get; set; }

    public virtual Electronico IdDocumentoNavigation { get; set; } = null!;

    public virtual ElectronicoEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Liquidacion IdLiquidacionNavigation { get; set; } = null!;
}
