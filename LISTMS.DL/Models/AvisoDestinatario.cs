using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AvisoDestinatario
{
    public int IdAviso { get; set; }

    public int IdUsuario { get; set; }

    public string Estatus { get; set; } = null!;
}
