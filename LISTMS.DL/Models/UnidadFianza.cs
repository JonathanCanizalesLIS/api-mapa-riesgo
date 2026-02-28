using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadFianza
{
    public int IdFianza { get; set; }

    public string NumFianza { get; set; } = null!;

    public DateTime FechaInternacion { get; set; }

    public DateTime FechaVencimiento { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdUnidad { get; set; }

    public int IdEmpresa { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    public virtual ICollection<UnidadSeguimiento> UnidadSeguimientos { get; set; } = new List<UnidadSeguimiento>();
}
