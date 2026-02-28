using System;
using System.Collections.Generic;

namespace MapaRiesgo.DL.Models;

public partial class SistemaOrigen
{
    public int IdSistemaOrigen { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
