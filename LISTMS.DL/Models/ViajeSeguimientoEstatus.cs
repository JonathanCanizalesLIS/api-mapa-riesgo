using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ViajeSeguimientoEstatus
{
    public int IdViaje { get; set; }

    public int IdSeguimiento { get; set; }

    public int IdEstatus { get; set; }

    public string Observaciones { get; set; } = null!;

    public DateTime FechaEstatus { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdEstatusCustom { get; set; }

    public decimal Latitud { get; set; }

    public decimal Longitud { get; set; }

    public virtual ViajeEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Viaje IdViajeNavigation { get; set; } = null!;
}
