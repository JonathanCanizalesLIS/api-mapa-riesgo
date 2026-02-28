using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TiposDocumento
{
    public int IdDocumento { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<BancoMovimientoDetalle> BancoMovimientoDetalles { get; set; } = new List<BancoMovimientoDetalle>();

    public virtual ICollection<BancoMovimiento> BancoMovimientos { get; set; } = new List<BancoMovimiento>();

    public virtual ICollection<BancoSolicitud> BancoSolicituds { get; set; } = new List<BancoSolicitud>();

    public virtual ICollection<TiposDocumentoIdioma> TiposDocumentoIdiomas { get; set; } = new List<TiposDocumentoIdioma>();
}
