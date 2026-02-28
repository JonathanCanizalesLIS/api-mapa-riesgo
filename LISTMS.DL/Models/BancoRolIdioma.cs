using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class BancoRolIdioma
{
    public int IdTipo { get; set; }

    public int IdIdioma { get; set; }

    public string Nombre { get; set; } = null!;
}
