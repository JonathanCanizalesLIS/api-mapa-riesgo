using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UnidadMtto
{
    public int IdUnidad { get; set; }

    public string? SigMtto { get; set; }

    public int? KmsSigMtto { get; set; }

    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
