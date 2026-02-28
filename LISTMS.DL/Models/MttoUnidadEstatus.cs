using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MttoUnidadEstatus
{
    public int TipoEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<MttoUnidadEstatusIdioma> MttoUnidadEstatusIdiomas { get; set; } = new List<MttoUnidadEstatusIdioma>();
}
