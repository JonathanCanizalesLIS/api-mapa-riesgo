using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ImpuestoImpuesto
{
    public int IdImpuesto { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
