using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UsoCfdiRegimenFiscal
{
    public int Id { get; set; }

    public string ClaveUsoCfdi { get; set; } = null!;

    public string ClaveRegimenFiscal { get; set; } = null!;
}
