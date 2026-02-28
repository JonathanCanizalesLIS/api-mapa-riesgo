using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class Botone
{
    public int IdBoton { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<BotonesSeguridad> BotonesSeguridads { get; set; } = new List<BotonesSeguridad>();
}
