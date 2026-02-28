using System;
using System.Collections.Generic;

namespace MapaRiesgo.DL.Models;

public partial class SistemaOrigen
{
    public int IdSistemaOrigen { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();

    public virtual ICollection<Unidad> Unidads { get; set; } = new List<Unidad>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
