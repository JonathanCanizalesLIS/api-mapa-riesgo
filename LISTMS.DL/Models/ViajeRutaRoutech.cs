using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ViajeRutaRoutech
{
    public int IdEmpresa { get; set; }

    public int IdViaje { get; set; }

    public int IdRutaRoutech { get; set; }

    public int IdSesion { get; set; }

    public DateTime FechaProceso { get; set; }

    public int? IdRoutechEstatus { get; set; }

    public virtual RoutechEstatus? IdRoutechEstatusNavigation { get; set; }

    public virtual Viaje IdViajeNavigation { get; set; } = null!;
}
