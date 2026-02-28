using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosTimbrado
{
    public int Id { get; set; }

    public int? EmpresaId { get; set; }

    public DateTime? FechaCompra { get; set; }

    public string? Activo { get; set; }

    public int? Cantidad { get; set; }

    public string? Observaciones { get; set; }

    public int? Saldo { get; set; }

    public virtual PagosEmpresa? Empresa { get; set; }
}
