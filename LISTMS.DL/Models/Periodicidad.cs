using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Periodicidad
{
    public int Id { get; set; }

    public string ClavePeriodicidad { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
