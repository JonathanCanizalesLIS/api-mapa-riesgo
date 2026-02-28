using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalCategorium
{
    public int IdCategoria { get; set; }

    public int IdEmpresa { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public int IdRiesgo { get; set; }

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdIngresoNavigation { get; set; } = null!;

    public virtual Usuario IdModificoNavigation { get; set; } = null!;

    public virtual ICollection<LiquidacionSueldoRelacion> LiquidacionSueldoRelacions { get; set; } = new List<LiquidacionSueldoRelacion>();

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
