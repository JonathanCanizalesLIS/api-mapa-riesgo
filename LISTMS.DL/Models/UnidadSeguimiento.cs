using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadSeguimiento
{
    public int IdUnidad { get; set; }

    public int IdSeguimiento { get; set; }

    public int IdEstatus { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaModifico { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public string Descripcion { get; set; } = null!;

    public int Actual { get; set; }

    public int IdPlaza { get; set; }

    public int IdViaje { get; set; }

    public int IdCliente { get; set; }

    public int Origen { get; set; }

    public int IdFianza { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual UnidadSeguimientoEstatus IdEstatusNavigation { get; set; } = null!;

    public virtual UnidadFianza IdFianzaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Plaza IdPlazaNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    public virtual Viaje IdViajeNavigation { get; set; } = null!;
}
