using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionSueldo
{
    public int IdTipoSueldo { get; set; }

    public string Descripcion { get; set; } = null!;

    public int TipoSueldo { get; set; }

    public int IdEmpresa { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdIngreso { get; set; }

    public int IdModifico { get; set; }

    public decimal Factor { get; set; }

    public string Estatus { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionSueldoRelacion> LiquidacionSueldoRelacions { get; set; } = new List<LiquidacionSueldoRelacion>();

    public virtual ICollection<LiquidacionSueldoRutum> LiquidacionSueldoRuta { get; set; } = new List<LiquidacionSueldoRutum>();

    public virtual LiquidacionSueldoTipo TipoSueldoNavigation { get; set; } = null!;
}
