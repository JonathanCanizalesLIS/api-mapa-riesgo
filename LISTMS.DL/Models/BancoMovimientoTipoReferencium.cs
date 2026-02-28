using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoMovimientoTipoReferencium
{
    public int IdTipoDoc { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdMetodoPago { get; set; }

    public virtual ICollection<BancoMovimientoTipoReferenciaIdioma> BancoMovimientoTipoReferenciaIdiomas { get; set; } = new List<BancoMovimientoTipoReferenciaIdioma>();

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();
}
