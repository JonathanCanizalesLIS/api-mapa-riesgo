using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MensajeIdioma
{
    public int IdIdioma { get; set; }

    public int IdMensaje { get; set; }

    public string? Mensaje { get; set; }

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual Mensaje IdMensajeNavigation { get; set; } = null!;
}
