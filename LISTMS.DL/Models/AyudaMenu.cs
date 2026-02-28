using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class AyudaMenu
{
    public int IdAyuda { get; set; }

    public int IdMenu { get; set; }

    public virtual SeguridadMenu IdMenuNavigation { get; set; } = null!;
}
