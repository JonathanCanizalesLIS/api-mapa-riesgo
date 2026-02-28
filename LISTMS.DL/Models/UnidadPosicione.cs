using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadPosicione
{
    public int Consecutivo { get; set; }

    public int IdProveedor { get; set; }

    public int IdUnidad { get; set; }

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Poslon { get; set; }

    public decimal Poslat { get; set; }

    public decimal? Velocidad { get; set; }

    public int? Angulo { get; set; }

    public string? Direccion { get; set; }

    public virtual InterfazProveedoresGp IdProveedorNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
