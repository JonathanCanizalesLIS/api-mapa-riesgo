using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Sugerencia
{
    public int IdSugerencia { get; set; }

    public string? Descripcion1 { get; set; }

    public string? Descripcion2 { get; set; }

    public string? Descripcion3 { get; set; }

    public int IdEmpresa { get; set; }

    public int IdUsuario { get; set; }

    public int IdEstatus { get; set; }

    public DateTime FechaIngreso { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual SugerenciaEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
