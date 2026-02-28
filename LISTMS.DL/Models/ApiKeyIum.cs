using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class ApiKeyIum
{
    public int IdApiKey { get; set; }

    public string? Servicio { get; set; }

    public string? Key { get; set; }

    public virtual FreeTier? FreeTier { get; set; }
}
