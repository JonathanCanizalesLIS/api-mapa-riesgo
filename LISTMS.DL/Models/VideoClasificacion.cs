using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class VideoClasificacion
{
    public int IdClasificacion { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
}
