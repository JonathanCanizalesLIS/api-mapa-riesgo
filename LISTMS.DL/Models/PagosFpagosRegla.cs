using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosFpagosRegla
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public int? FpagoId { get; set; }

    public decimal? PorcentajeComision { get; set; }
}
