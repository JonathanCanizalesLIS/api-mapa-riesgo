using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PagosCliente
{
    public string? Name { get; set; }

    public string? Activo { get; set; }

    public int Id { get; set; }

    public virtual ICollection<PagosUsuario> PagosUsuarios { get; set; } = new List<PagosUsuario>();
}
