using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ObjetoImpuestoIdioma
{
    public int IdObjetoImpuesto { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdIdioma { get; set; }
}
