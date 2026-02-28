using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SeguridadMenuAyudum
{
    public int IdMenu { get; set; }

    public int IdAyuda { get; set; }

    public string RutaAyuda { get; set; } = null!;

    public virtual SeguridadAyudum IdAyudaNavigation { get; set; } = null!;

    public virtual SeguridadMenu IdMenuNavigation { get; set; } = null!;
}
