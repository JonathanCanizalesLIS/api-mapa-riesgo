using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class TasaCuotum
{
    public int IdTasaCuota { get; set; }

    public decimal ValorMaximo { get; set; }

    public string Impuesto { get; set; } = null!;

    public string Factor { get; set; } = null!;
}
