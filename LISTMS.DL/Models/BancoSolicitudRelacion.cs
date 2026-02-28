using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoSolicitudRelacion
{
    public int IdSolicitud { get; set; }

    public int IdMovimiento { get; set; }

    public DateTime Fecha { get; set; }

    public virtual BancoMovimiento IdMovimientoNavigation { get; set; } = null!;

    public virtual BancoSolicitud IdSolicitudNavigation { get; set; } = null!;
}
