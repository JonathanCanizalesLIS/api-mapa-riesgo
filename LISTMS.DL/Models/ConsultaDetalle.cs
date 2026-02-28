using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConsultaDetalle
{
    public int IdConsulta { get; set; }

    public int Consecutivo { get; set; }

    public string? NombreInterno { get; set; }

    public string TipoDato { get; set; } = null!;

    public string FormatoDefault { get; set; } = null!;

    public int AnchoDefault { get; set; }

    public string AlineacionDefault { get; set; } = null!;

    public string AliasInterno { get; set; } = null!;

    public int Requerido { get; set; }

    public int VisibleDefault { get; set; }

    public int? Sumar { get; set; }

    public int? Agrupar { get; set; }

    public int Orden { get; set; }

    public int IdEmpresa { get; set; }

    public virtual ICollection<ConsultaDetalleIdioma> ConsultaDetalleIdiomas { get; set; } = new List<ConsultaDetalleIdioma>();

    public virtual Consultum IdConsultaNavigation { get; set; } = null!;
}
