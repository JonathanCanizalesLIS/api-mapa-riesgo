using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TipoOperacionPeru
{
    public int IdTipoOperacion { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;
}
