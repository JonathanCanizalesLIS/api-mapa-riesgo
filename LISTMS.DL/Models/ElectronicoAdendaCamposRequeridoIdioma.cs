using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ElectronicoAdendaCamposRequeridoIdioma
{
    public int IdRequerido { get; set; }

    public int IdIdioma { get; set; }

    public string NombreEstandar { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual ElectronicoAdendaCamposRequerido IdRequeridoNavigation { get; set; } = null!;
}
