using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConsultaAlineacionIdioma
{
    public int IdAlineacion { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ConsultaAlineacion IdAlineacionNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
