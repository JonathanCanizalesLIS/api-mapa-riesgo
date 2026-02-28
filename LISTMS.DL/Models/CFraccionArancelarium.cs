using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class CFraccionArancelarium
{
    public int IdFraccionArancelaria { get; set; }

    public string Clave { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Estatus { get; set; } = null!;

    public int? IdPais { get; set; }
}
