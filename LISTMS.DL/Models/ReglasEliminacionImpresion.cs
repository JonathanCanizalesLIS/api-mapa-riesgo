using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ReglasEliminacionImpresion
{
    public int Id { get; set; }

    public int? IdPais { get; set; }

    public int? IdImpresion { get; set; }

    public int? Consecutivo { get; set; }
}
