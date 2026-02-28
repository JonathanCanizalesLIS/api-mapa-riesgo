using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class MttoUnidadTipoMtto
{
    public int TipoMtto { get; set; }

    public string Nombre { get; set; } = null!;

    public int Orden { get; set; }

    public virtual ICollection<MttoUnidadTipoMttoIdioma> MttoUnidadTipoMttoIdiomas { get; set; } = new List<MttoUnidadTipoMttoIdioma>();
}
