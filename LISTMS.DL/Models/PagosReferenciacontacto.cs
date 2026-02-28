using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosReferenciacontacto
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Descripcion { get; set; }

    public int? Orden { get; set; }
}
