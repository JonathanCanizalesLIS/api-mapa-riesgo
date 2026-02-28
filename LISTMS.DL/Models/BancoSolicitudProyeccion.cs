using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoSolicitudProyeccion
{
    public int IdSolicitud { get; set; }

    public int IdConsecutivo { get; set; }

    public DateTime FechaDoc { get; set; }
}
