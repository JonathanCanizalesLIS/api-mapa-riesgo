using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class PermisionarioTarifaTipo
{
    public int IdTipoTarifa { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<PermisionarioTarifaTipoIdioma> PermisionarioTarifaTipoIdiomas { get; set; } = new List<PermisionarioTarifaTipoIdioma>();

    public virtual ICollection<PermisionarioTarifa> PermisionarioTarifas { get; set; } = new List<PermisionarioTarifa>();
}
