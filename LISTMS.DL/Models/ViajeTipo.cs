using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ViajeTipo
{
    public int IdTipo { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual ICollection<CotizacionViajeFactore> CotizacionViajeFactores { get; set; } = new List<CotizacionViajeFactore>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionSueldoRelacion> LiquidacionSueldoRelacions { get; set; } = new List<LiquidacionSueldoRelacion>();

    public virtual ICollection<PermisionarioTarifaConfiguracion> PermisionarioTarifaConfiguracions { get; set; } = new List<PermisionarioTarifaConfiguracion>();

    public virtual ICollection<Viaje> Viajes { get; set; } = new List<Viaje>();
}
