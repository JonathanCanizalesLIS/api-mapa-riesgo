using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosGrupo
{
    public string? Name { get; set; }

    public int? Seguridad { get; set; }

    public DateTime? Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public byte[]? Ts { get; set; }

    public int Id { get; set; }

    public virtual ICollection<PagosRegla> PagosReglas { get; set; } = new List<PagosRegla>();

    public virtual ICollection<PagosUsuariosGrupo> PagosUsuariosGrupos { get; set; } = new List<PagosUsuariosGrupo>();
}
