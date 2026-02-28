using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EdiSesionUsuario
{
    public int IdEdiSesionUsuario { get; set; }

    public int IdEdiUsuario { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime UltimaActividad { get; set; }

    public string? Navegador { get; set; }

    public string? Token { get; set; }

    public virtual EdiUsuario IdEdiUsuarioNavigation { get; set; } = null!;
}
