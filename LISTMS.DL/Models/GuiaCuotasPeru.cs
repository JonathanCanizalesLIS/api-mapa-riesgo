using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GuiaCuotasPeru
{
    public int IdGuia { get; set; }

    public int Consecutivo { get; set; }

    public string? Descripcion { get; set; }

    public decimal Monto { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Guium IdGuiaNavigation { get; set; } = null!;
}
