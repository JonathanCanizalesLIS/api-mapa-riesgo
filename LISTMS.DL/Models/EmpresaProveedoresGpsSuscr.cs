using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EmpresaProveedoresGpsSuscr
{
    public int Consecutivo { get; set; }

    public int IdProveedor { get; set; }

    public int IdEmpresa { get; set; }

    public int Suscriptor { get; set; }

    public int Transaccion { get; set; }

    public virtual EmpresaProveedoresGp Id { get; set; } = null!;
}
