using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MetaIndicador
{
    public int IdIndicador { get; set; }

    public string NombreCampo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
