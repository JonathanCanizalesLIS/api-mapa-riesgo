using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConsultaDetalleIdioma
{
    public int IdIdioma { get; set; }

    public int IdConsulta { get; set; }

    public string NombreExterno { get; set; } = null!;

    public int Consecutivo { get; set; }

    public string DescripcionExterna { get; set; } = null!;

    public virtual ConsultaDetalle ConsultaDetalle { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
