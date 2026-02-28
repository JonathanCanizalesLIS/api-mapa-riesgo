using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PermisionarioTarifaConfiguracion
{
    public int IdTarifaConfiguracion { get; set; }

    public int IdLineaUnidad { get; set; }

    public int ViajeTipo { get; set; }

    public int IdTarifaPermisionario { get; set; }

    public int IdEmpresa { get; set; }

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime? FechaModifico { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual UnidadLinea IdLineaUnidadNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual PermisionarioTarifa IdTarifaPermisionarioNavigation { get; set; } = null!;

    public virtual ViajeTipo ViajeTipoNavigation { get; set; } = null!;
}
