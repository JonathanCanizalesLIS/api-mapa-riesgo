using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MttoUnidad
{
    public int IdMtto { get; set; }

    public int IdUnidad { get; set; }

    public int TipoMtto { get; set; }

    public string Mantenimiento { get; set; } = null!;

    public int IdEstatus { get; set; }

    public int Kms { get; set; }

    public string? SigMtto { get; set; }

    public int? KmsSigMtto { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime? FechaSigMtto { get; set; }

    public decimal Total { get; set; }

    public decimal TotalManoObra { get; set; }

    public decimal TotalRefacc { get; set; }

    public string Observaciones { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public string Correlativo { get; set; } = null!;

    public string? Folio { get; set; }

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;

    public virtual ICollection<MttoUnidadDetalle> MttoUnidadDetalles { get; set; } = new List<MttoUnidadDetalle>();
}
