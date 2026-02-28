using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PreguntaFrecuente
{
    public int IdPregunta { get; set; }

    public int IdIdioma { get; set; }

    public string Titulo { get; set; } = null!;

    public string Resumen { get; set; } = null!;

    public string TextoAyuda { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual ICollection<PreguntaVentana> PreguntaVentanas { get; set; } = new List<PreguntaVentana>();
}
