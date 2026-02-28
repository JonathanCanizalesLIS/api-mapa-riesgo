using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PermisionarioTarifa
{
    public int IdTarifaPermisionario { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdTipoTarifa { get; set; }

    public int IdEmpresa { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdIngreso { get; set; }

    public DateTime? FechaModifico { get; set; }

    public int IdModifico { get; set; }

    public decimal Factor { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual PermisionarioTarifaTipo IdTipoTarifaNavigation { get; set; } = null!;

    public virtual ICollection<PermisionarioTarifaConfiguracion> PermisionarioTarifaConfiguracions { get; set; } = new List<PermisionarioTarifaConfiguracion>();

    public virtual ICollection<PermisionarioTarifaRutum> PermisionarioTarifaRuta { get; set; } = new List<PermisionarioTarifaRutum>();
}
