using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoControlPagosDetalle
{
    public int IdPagoElectronico { get; set; }

    public int IdFactura { get; set; }

    public string IdMetodoPago { get; set; } = null!;

    public string EstatusPagoFactura { get; set; } = null!;

    public int NumParcialidad { get; set; }
}
