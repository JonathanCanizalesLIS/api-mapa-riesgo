using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class NumUnidade
{
    public int IdNumUnidades { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
