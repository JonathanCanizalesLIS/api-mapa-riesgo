using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCreditoCfdiRelacion
{
    public int IdCredito { get; set; }

    public int IdGuiaRelacionada { get; set; }

    public string FolioFactura { get; set; } = null!;

    public int TipoRelacion { get; set; }

    public string Uuid { get; set; } = null!;
}
