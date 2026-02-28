using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoLiquidacionDirectum
{
    public int IdLiqdirElectronica { get; set; }

    public int IdDocumento { get; set; }

    public int IdLiquidacionDirecta { get; set; }

    public int IdEstatus { get; set; }

    public virtual Electronico IdDocumentoNavigation { get; set; } = null!;

    public virtual ElectronicoEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual LiquidacionDirectum IdLiquidacionDirectaNavigation { get; set; } = null!;
}
