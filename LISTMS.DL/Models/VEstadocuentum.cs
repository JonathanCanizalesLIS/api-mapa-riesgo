using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VEstadocuentum
{
    public int IdCliente { get; set; }

    public int TipoDocumento { get; set; }

    public string? Referencia { get; set; }

    public string Folio { get; set; } = null!;

    public string FolioRelacionado { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int IdEmpresa { get; set; }

    public decimal? Cargo { get; set; }

    public decimal? Abono { get; set; }

    public decimal TipoCambio { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public int IdMoneda { get; set; }
}
