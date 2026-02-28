using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Video
{
    public int IdVideo { get; set; }

    public int IdIdioma { get; set; }

    public int Visiblemenu { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdClasificacion { get; set; }

    public string Estatus { get; set; } = null!;

    public int IdIngreso { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string RutaVideo { get; set; } = null!;

    public DateTime FechaModifico { get; set; }

    public int IdModifico { get; set; }

    public string RutaImagen { get; set; } = null!;

    public virtual VideoClasificacion IdClasificacionNavigation { get; set; } = null!;

    public virtual Idioma IdIdiomaNavigation { get; set; } = null!;

    public virtual ICollection<Ventana> IdVentanas { get; set; } = new List<Ventana>();
}
