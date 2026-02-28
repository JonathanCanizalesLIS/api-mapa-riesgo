using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadPosicionesHistorial
{
    public int Consecutivo { get; set; }

    public int IdProveedor { get; set; }

    public string Antena { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Poslon { get; set; }

    public decimal Poslat { get; set; }

    public decimal Velocidad { get; set; }

    public int Angulo { get; set; }

    public string Direccion { get; set; } = null!;

    public virtual InterfazProveedoresGp IdProveedorNavigation { get; set; } = null!;
}
