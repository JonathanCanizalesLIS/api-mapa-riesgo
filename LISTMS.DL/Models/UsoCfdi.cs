using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class UsoCfdi
{
    public int IdUsoCfdi { get; set; }

    public string? Clave { get; set; }

    public string Descripcion { get; set; } = null!;

    public string PFisica { get; set; } = null!;

    public string PMoral { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
