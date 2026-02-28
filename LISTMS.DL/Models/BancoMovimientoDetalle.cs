using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoMovimientoDetalle
{
    public int IdMovimiento { get; set; }

    public int Consecutivo { get; set; }

    public decimal Monto { get; set; }

    public int IdConcepto { get; set; }

    public int IdDocumento { get; set; }

    public string ReferenciaDocumento { get; set; } = null!;

    public int IdUnidad { get; set; }

    public int IdViaje { get; set; }

    public decimal? MontoIva { get; set; }

    public decimal? MontoRetencion { get; set; }

    public decimal? MontoTotal { get; set; }

    public string? DesglosaIva { get; set; }

    public string? DesglosaRetencion { get; set; }

    public int? IdRetencion { get; set; }

    public virtual BancoConcepto IdConceptoNavigation { get; set; } = null!;

    public virtual TiposDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual BancoMovimiento IdMovimientoNavigation { get; set; } = null!;
}
