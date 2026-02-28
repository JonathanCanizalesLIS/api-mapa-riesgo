using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EdiShipmentStatus
{
    public int IdEdiShipmentStatus { get; set; }

    public int? IdViaje { get; set; }

    public int IdEdiLoadTender { get; set; }

    public DateTime? FechaTransmision { get; set; }

    public int IdentificacionReferencia { get; set; }

    public virtual ICollection<EdiLine> EdiLines { get; set; } = new List<EdiLine>();

    public virtual ICollection<EdiParty> EdiParties { get; set; } = new List<EdiParty>();

    public virtual EdiLoadTender IdEdiLoadTenderNavigation { get; set; } = null!;

    public virtual Viaje? IdViajeNavigation { get; set; }
}
