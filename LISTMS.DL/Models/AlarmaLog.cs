using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AlarmaLog
{
    public int IdAlarma { get; set; }

    public int Consecutivo { get; set; }

    public DateTime Fecha { get; set; }

    public string Mensaje { get; set; } = null!;

    public virtual Alarma IdAlarmaNavigation { get; set; } = null!;
}
