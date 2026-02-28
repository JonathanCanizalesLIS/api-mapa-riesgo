using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalTipoPersona
{
    public int IdTipoPersona { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
