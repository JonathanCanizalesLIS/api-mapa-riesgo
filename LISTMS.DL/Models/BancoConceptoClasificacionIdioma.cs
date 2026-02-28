using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoConceptoClasificacionIdioma
{
    public int IdClasificacion { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual BancoConceptoClasificacion IdClasificacionNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
