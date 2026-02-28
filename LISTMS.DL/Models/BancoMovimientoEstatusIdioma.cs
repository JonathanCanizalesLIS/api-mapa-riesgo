using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoMovimientoEstatusIdioma
{
    public string Estatus { get; set; } = null!;

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual BancoMovimientoEstatus EstatusNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
