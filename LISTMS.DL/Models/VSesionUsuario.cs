using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VSesionUsuario
{
    public long IdSesion { get; set; }

    public int? IdUsuario { get; set; }

    public string? Usuario { get; set; }

    public int? IdEmpresa { get; set; }

    public string? Nombre { get; set; }

    public string? Navegador { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime? UltimaActividad { get; set; }
}
