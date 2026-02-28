using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosListimbrado
{
    public int Id { get; set; }

    public DateTime? FechaCompra { get; set; }

    public string? Activo { get; set; }

    public int? Cantidad { get; set; }

    public string? Observaciones { get; set; }

    public int? Saldo { get; set; }

    public string? Proveedor { get; set; }

    public decimal? Precio { get; set; }
}
