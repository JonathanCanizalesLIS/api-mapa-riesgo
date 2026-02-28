using System;
using System.Collections.Generic;

namespace LISTMS.DL.Models;

public partial class CombustibleEstatus
{
    public int IdEstatus { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<CombustibleEstatusIdioma> CombustibleEstatusIdiomas { get; set; } = new List<CombustibleEstatusIdioma>();

    public virtual ICollection<CombustibleVale> CombustibleVales { get; set; } = new List<CombustibleVale>();
}
