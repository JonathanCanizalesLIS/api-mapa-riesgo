using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PersonalTipoContrato
{
    public int IdTipoContrato { get; set; }

    public string ClaveSat { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
