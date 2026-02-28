using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Ventana
{
    public int IdVentana { get; set; }

    public string NombreArchivo { get; set; } = null!;

    public virtual ICollection<Consultum> Consulta { get; set; } = new List<Consultum>();

    public virtual ICollection<PreguntaVentana> PreguntaVentanas { get; set; } = new List<PreguntaVentana>();

    public virtual ICollection<Tooltip> Tooltips { get; set; } = new List<Tooltip>();

    public virtual ICollection<Video> IdVideos { get; set; } = new List<Video>();
}
