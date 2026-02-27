using System;
using System.Collections.Generic;

namespace MapaRiesgo.DL.Models;

public partial class Sesion
{
    public int IdSesion { get; set; }

    public int IdUsuario { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime UltimaActividad { get; set; }

    public string? Navegador { get; set; }

    public string? Token { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
