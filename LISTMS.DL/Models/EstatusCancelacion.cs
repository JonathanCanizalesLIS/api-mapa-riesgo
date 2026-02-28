using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EstatusCancelacion
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
