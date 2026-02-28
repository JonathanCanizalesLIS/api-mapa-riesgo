using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SesionUsuario
{
    public int IdSesion { get; set; }

    public int IdUsuario { get; set; }

    public int IdEmpresa { get; set; }

    public string? Token { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? UltimaActividad { get; set; }

    public string? Navegador { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
