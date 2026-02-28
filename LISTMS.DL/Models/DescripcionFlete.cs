using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class DescripcionFlete
{
    public int IdDescripcionFlete { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;
}
