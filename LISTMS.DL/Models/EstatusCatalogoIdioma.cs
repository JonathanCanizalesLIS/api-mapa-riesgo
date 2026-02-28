using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EstatusCatalogoIdioma
{
    public string Estatus { get; set; } = null!;

    public int IdIdioma { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual EstatusCatalogo EstatusNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
