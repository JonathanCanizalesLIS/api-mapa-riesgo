using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoNotaCargo
{
    public int IdCargoElectronica { get; set; }

    public int IdDocumento { get; set; }

    public int IdCargo { get; set; }

    public int IdEstatus { get; set; }

    public virtual NotaCargo IdCargoNavigation { get; set; } = null!;

    public virtual Electronico IdDocumentoNavigation { get; set; } = null!;

    public virtual ElectronicoEstatus IdEstatusNavigation { get; set; } = null!;
}
