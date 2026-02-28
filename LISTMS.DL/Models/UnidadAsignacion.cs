using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadAsignacion
{
    public int IdAsignacion { get; set; }

    public int IdUnidad { get; set; }

    public int IdElemento { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
