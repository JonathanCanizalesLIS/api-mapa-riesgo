using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoGuium
{
    public int IdGuiaElectronica { get; set; }

    public int IdDocumento { get; set; }

    public int IdGuia { get; set; }

    public int IdEstatus { get; set; }

    public virtual Electronico IdDocumentoNavigation { get; set; } = null!;

    public virtual ElectronicoEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Guium IdGuiaNavigation { get; set; } = null!;
}
