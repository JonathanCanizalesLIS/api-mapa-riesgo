using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoSolicitudViaje
{
    public int IdSolicitud { get; set; }

    public int IdViaje { get; set; }

    public virtual BancoSolicitud IdSolicitudNavigation { get; set; } = null!;

    public virtual Viaje IdViajeNavigation { get; set; } = null!;
}
