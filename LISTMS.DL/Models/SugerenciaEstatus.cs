using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class SugerenciaEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Sugerencia> Sugerencia { get; set; } = new List<Sugerencia>();

    public virtual ICollection<SugerenciaEstatusIdioma> SugerenciaEstatusIdiomas { get; set; } = new List<SugerenciaEstatusIdioma>();
}
