using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class LisSecuencium
{
    public int Number { get; set; }

    public string Type { get; set; } = null!;

    public int? Low { get; set; }

    public int? High { get; set; }
}
