using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ConfiguracionRangoVencimiento
{
    public int IdRangoVencimiento { get; set; }

    public int? Tipo { get; set; }

    public string DescRangoVencimiento { get; set; } = null!;

    public int? Inicio { get; set; }

    public int? Fin { get; set; }
}
