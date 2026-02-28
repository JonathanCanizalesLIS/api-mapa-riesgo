using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LiquidacionSueldoTipoIdioma
{
    public int TipoSueldo { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual LiquidacionSueldoTipo TipoSueldoNavigation { get; set; } = null!;
}
