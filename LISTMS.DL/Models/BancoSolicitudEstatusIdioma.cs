using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoSolicitudEstatusIdioma
{
    public string Estatus { get; set; } = null!;

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual BancoSolicitudEstatus EstatusNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
