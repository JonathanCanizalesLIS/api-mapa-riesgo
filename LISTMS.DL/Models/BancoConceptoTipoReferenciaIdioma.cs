using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoConceptoTipoReferenciaIdioma
{
    public int IdTipoReferencia { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual BancoConceptoTipoReferencium IdTipoReferenciaNavigation { get; set; } = null!;
}
