using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoConceptoNaturalezaIdioma
{
    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdNaturaleza { get; set; }

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual BancoConceptoNaturaleza IdNaturalezaNavigation { get; set; } = null!;
}
