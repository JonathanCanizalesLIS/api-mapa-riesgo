using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalOperador
{
    public int IdPersonal { get; set; }

    public string Licencia { get; set; } = null!;

    public DateTime? FechaVencelicencia { get; set; }

    public string Tipolicencia { get; set; } = null!;

    public virtual Personal IdPersonalNavigation { get; set; } = null!;
}
