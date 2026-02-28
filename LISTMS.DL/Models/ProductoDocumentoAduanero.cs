using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ProductoDocumentoAduanero
{
    public int IdDocumentoAduanero { get; set; }

    public string? Clave { get; set; }

    public string? Descripcion { get; set; }

    public string? Estatus { get; set; }
}
