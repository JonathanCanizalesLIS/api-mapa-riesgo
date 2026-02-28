using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalRegiman
{
    public int IdRegimen { get; set; }

    public string? ClaveSat { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;
}
