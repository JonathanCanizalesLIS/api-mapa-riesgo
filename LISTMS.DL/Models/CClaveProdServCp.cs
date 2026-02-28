using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class CClaveProdServCp
{
    public int IdClaveprodserv { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string MaterialPeligrosoCps { get; set; } = null!;

    public int IdPais { get; set; }
}
