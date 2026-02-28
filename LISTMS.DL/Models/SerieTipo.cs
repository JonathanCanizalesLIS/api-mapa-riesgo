using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SerieTipo
{
    public int IdTipoSerie { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<SerieTipoIdioma> SerieTipoIdiomas { get; set; } = new List<SerieTipoIdioma>();
}
