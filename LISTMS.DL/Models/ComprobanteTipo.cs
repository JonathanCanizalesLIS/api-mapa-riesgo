using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ComprobanteTipo
{
    public int IdComprobanteTipo { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal ValorMaximo1 { get; set; }

    public decimal ValorMaximo2 { get; set; }
}
