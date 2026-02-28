using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalTipoEmpleado
{
    public int IdTipoEmpleado { get; set; }

    public string Clave { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
