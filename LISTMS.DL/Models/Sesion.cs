using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Sesion
{
    public long IdSesion { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaInicio { get; set; }

    public string? Navegador { get; set; }

    public DateTime? UltimaActividad { get; set; }
}
