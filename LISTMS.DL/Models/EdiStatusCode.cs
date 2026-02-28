using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class EdiStatusCode
{
    public int IdEdiStatusCode { get; set; }

    public string Key { get; set; } = null!;

    public string? Description { get; set; }

    public string? Usage { get; set; }
}
