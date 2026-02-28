using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NotaCargoAdendum
{
    public int IdCargo { get; set; }

    public int IdAdenda { get; set; }

    public int Consecutivo { get; set; }

    public string Campo { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public virtual ElectronicoAdendum IdAdendaNavigation { get; set; } = null!;

    public virtual NotaCargo IdCargoNavigation { get; set; } = null!;
}
