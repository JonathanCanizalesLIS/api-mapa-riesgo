using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoControlPago
{
    public int IdPagoElectronico { get; set; }

    public int IdPago { get; set; }

    public int IdDocumento { get; set; }

    public int IdEstatus { get; set; }

    public decimal MontoPagoTimbrado { get; set; }

    public int IdDocRelacionado { get; set; }

    public string UuidRelacionado { get; set; } = null!;

    public DateTime? FechaCancelacion { get; set; }
}
