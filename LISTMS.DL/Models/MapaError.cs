using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MapaError
{
    public int IdMapaError { get; set; }

    public string ErrorServicio { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
