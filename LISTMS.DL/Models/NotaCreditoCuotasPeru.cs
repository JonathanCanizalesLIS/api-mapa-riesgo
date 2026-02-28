using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCreditoCuotasPeru
{
    public int IdCredito { get; set; }

    public int Consecutivo { get; set; }

    public string? Descripcion { get; set; }

    public decimal Monto { get; set; }

    public DateTime Fecha { get; set; }

    public virtual NotaCredito IdCreditoNavigation { get; set; } = null!;
}
