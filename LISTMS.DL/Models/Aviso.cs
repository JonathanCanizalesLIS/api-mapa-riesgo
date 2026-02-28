using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Aviso
{
    public int IdAviso { get; set; }

    public int IdRemitente { get; set; }

    public string Asunto { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public string Link { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public int IdModifico { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaModifico { get; set; }

    public virtual Usuario IdRemitenteNavigation { get; set; } = null!;
}
