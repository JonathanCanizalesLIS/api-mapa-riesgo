using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Aduana
{
    public int IdAduana { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
