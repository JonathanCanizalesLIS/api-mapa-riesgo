using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MensajeClasificacionIdioma
{
    public int IdClasificacion { get; set; }

    public int IdIdioma { get; set; }

    public string TextoAceptar { get; set; } = null!;

    public string TextoCancelar { get; set; } = null!;

    public virtual MensajeClasificacion IdClasificacionNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;
}
