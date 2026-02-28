using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConsultaVistaDetalle
{
    public int IdVista { get; set; }

    public int Consecutivo { get; set; }

    public string NombreExterno { get; set; } = null!;

    public string TipoDato { get; set; } = null!;

    public int Orden { get; set; }

    public int Requerido { get; set; }

    public string Formato { get; set; } = null!;

    public int AnchoColumna { get; set; }

    public string Alinear { get; set; } = null!;

    public string? NombreInterno { get; set; }

    public int Visible { get; set; }

    public string Alias { get; set; } = null!;

    public int Sumar { get; set; }

    public int Agrupar { get; set; }

    public int Ordenar { get; set; }

    public virtual ConsultaVistum IdVistaNavigation { get; set; } = null!;
}
