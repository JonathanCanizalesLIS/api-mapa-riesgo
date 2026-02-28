using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalPeriodicidad
{
    public int IdPeriodicidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Estatus { get; set; } = null!;
}
