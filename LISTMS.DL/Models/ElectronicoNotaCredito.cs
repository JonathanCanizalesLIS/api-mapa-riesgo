using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoNotaCredito
{
    public int IdCreditoElectronica { get; set; }

    public int IdDocumento { get; set; }

    public int IdCredito { get; set; }

    public int IdEstatus { get; set; }

    public virtual NotaCredito IdCreditoNavigation { get; set; } = null!;

    public virtual Electronico IdDocumentoNavigation { get; set; } = null!;

    public virtual ElectronicoEstatus IdEstatusNavigation { get; set; } = null!;
}
