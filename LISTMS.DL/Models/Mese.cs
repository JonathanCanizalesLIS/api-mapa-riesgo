using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Mese
{
    public int Id { get; set; }

    public string ClaveMeses { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
