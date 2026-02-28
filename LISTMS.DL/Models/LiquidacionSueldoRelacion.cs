using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionSueldoRelacion
{
    public int IdSueldoRelacion { get; set; }

    public int IdTipoSueldo { get; set; }

    public int IdCategoria { get; set; }

    public int ViajeTipo { get; set; }

    public int IdEmpresa { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual PersonalCategorium IdCategoriaNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual LiquidacionSueldo IdTipoSueldoNavigation { get; set; } = null!;

    public virtual ViajeTipo ViajeTipoNavigation { get; set; } = null!;
}
