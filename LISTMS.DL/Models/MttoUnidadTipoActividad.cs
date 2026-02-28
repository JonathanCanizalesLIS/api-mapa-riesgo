using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MttoUnidadTipoActividad
{
    public int IdTipoAct { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<MttoUnidadTipoActividadIdioma> MttoUnidadTipoActividadIdiomas { get; set; } = new List<MttoUnidadTipoActividadIdioma>();
}
