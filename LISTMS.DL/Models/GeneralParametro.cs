using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class GeneralParametro
{
    public string Nombre { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public string Modulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string IdParametro { get; set; } = null!;
}
