using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ProveedorCombustible
{
    public int IdProveedor { get; set; }

    public int IdTarifa { get; set; }

    public string ControlaFolio { get; set; } = null!;

    public string Consecutivo { get; set; } = null!;

    public virtual Proveedor IdProveedorNavigation { get; set; } = null!;

    public virtual CombustibleTarifa IdTarifaNavigation { get; set; } = null!;
}
