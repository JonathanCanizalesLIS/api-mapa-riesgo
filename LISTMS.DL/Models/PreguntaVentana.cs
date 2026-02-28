using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PreguntaVentana
{
    public int IdPregunta { get; set; }

    public int IdVentana { get; set; }

    public int VisibleVentana { get; set; }

    public virtual PreguntaFrecuente IdPreguntaNavigation { get; set; } = null!;

    public virtual Ventana IdVentanaNavigation { get; set; } = null!;
}
