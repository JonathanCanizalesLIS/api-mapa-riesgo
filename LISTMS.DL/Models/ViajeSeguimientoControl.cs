using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ViajeSeguimientoControl
{
    public int Consecutivo { get; set; }

    public int IdEstatus { get; set; }

    public int IdEmpresa { get; set; }

    public int Activo { get; set; }

    public int EstatusAnterior { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ViajeEstatus IdEstatusNavigation { get; set; } = null!;
}
