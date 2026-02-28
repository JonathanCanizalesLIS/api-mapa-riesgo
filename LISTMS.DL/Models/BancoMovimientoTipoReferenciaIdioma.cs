using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoMovimientoTipoReferenciaIdioma
{
    public int IdTipoDoc { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public string TituloReferencia { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual BancoMovimientoTipoReferencium IdTipoDocNavigation { get; set; } = null!;
}
