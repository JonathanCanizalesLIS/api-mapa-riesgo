using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EmpresaProveedoresGp
{
    public int IdProveedor { get; set; }

    public int IdEmpresa { get; set; }

    public string Usuario { get; set; } = null!;

    public string Contrasenia { get; set; } = null!;

    public string Empresa { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public virtual ICollection<EmpresaProveedoresGpsSuscr> EmpresaProveedoresGpsSuscrs { get; set; } = new List<EmpresaProveedoresGpsSuscr>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual InterfazProveedoresGp IdProveedorNavigation { get; set; } = null!;
}
